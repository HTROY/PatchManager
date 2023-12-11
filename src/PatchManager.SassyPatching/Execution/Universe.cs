﻿using Antlr4.Runtime;
using PatchManager.SassyPatching.Attributes;
using PatchManager.SassyPatching.Interfaces;
using PatchManager.SassyPatching.Nodes;
using PatchManager.Shared.Interfaces;
using SassyPatchGrammar;
using System.Reflection;
using PatchManager.SassyPatching.Nodes.Statements.TopLevel;

namespace PatchManager.SassyPatching.Execution;

/// <summary>
/// The state that all executing patches share
/// </summary>
public class Universe
{
    /// <summary>
    /// This contains all rule sets that have been found in all assemblies
    /// </summary>
    public static readonly Dictionary<string, IPatcherRuleSet> RuleSets;

    /// <summary>
    /// This contains all the managed libraries that have been found in all assemblies
    /// </summary>
    public static readonly Dictionary<string, PatchLibrary> AllManagedLibraries;

    private static List<string> _preloadedLabels;

    static Universe()
    {
        RuleSets = new();
        AllManagedLibraries = new();
        _preloadedLabels = new();
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            // Only use public rule sets
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsAbstract || type.IsInterface) continue;
                if (typeof(IPatcherRuleSet).IsAssignableFrom(type))
                {
                    var rsAttribute = type.GetCustomAttribute<PatcherRulesetAttribute>();
                    if (rsAttribute != null)
                    {
                        RuleSets[rsAttribute.RulesetName] = (IPatcherRuleSet)Activator.CreateInstance(type);
                        _preloadedLabels.AddRange(rsAttribute.PreloadLabels);
                    }
                }

                var sassyLibraryAttribute = type.GetCustomAttribute<SassyLibraryAttribute>();
                if (sassyLibraryAttribute != null)
                {
                    var name = sassyLibraryAttribute.Mod + ":" + sassyLibraryAttribute.Library;
                    AllManagedLibraries[name] = new ManagedPatchLibrary(type);
                    Console.WriteLine($"Registered a managed library, {name}");
                }
            }
        }
    }

    /// <summary>
    /// All stages defined by every mod
    /// </summary>
    public Dictionary<string, ulong> AllStages = new();

    // Populated from Space Warps mod list come 1.3.0
    public List<string> AllMods = new();

    /// <summary>
    /// This is an action that is taken
    /// </summary>
    public readonly Action<ITextPatcher> RegisterPatcher;


    /// <summary>
    /// Register a generator patch
    /// </summary>
    public readonly Action<ITextAssetGenerator> RegisterGenerator;
    
    /// <summary>
    /// This logs errors in this universe
    /// </summary>
    private readonly Action<string> _errorLogger;


    /// <summary>
    /// The list of labels that this universe needs loaded to respond to
    /// </summary>
    public List<string> LoadedLabels;

    /// <summary>
    /// This logs any message that is not an error in the universe
    /// </summary>
    public readonly Action<string> MessageLogger;

    private readonly List<(string id, SassyPatch patch)> ToRegister = new();

    /// <summary>
    /// Create a new universal state
    /// </summary>
    /// <param name="registerPatcher">This action receives patchers and registers them for later execution</param>
    /// <param name="errorLogger">The action to be taken to log an error</param>
    /// <param name="messageLogger">The action to be taken to log a message</param>
    public Universe(Action<ITextPatcher> registerPatcher, Action<string> errorLogger, Action<string> messageLogger, Action<ITextAssetGenerator> registerGenerator, List<string> allMods)
    {
        RegisterPatcher = registerPatcher;
        _errorLogger = errorLogger;
        MessageLogger = messageLogger;
        RegisterGenerator = registerGenerator;
        LoadedLabels = new List<string>(_preloadedLabels);
        AllMods = allMods;
        SetupBasePriorities(allMods);
    }

    // TODO: Fix this so that other mods stages get their guids working
    /// <summary>
    /// All the libraries in this "universe"
    /// </summary>
    public readonly Dictionary<string, PatchLibrary> AllLibraries = new(AllManagedLibraries);

    private class LoadException : Exception
    {
        public LoadException(string message) : base(message)
        {
        }
    }

    private class ParserListener : IAntlrErrorListener<IToken>
    {
        internal bool Errored = false;
        internal Action<string> ErrorLogger;
        internal string File;
        internal ParserListener(string file, Action<string> errorLogger)
        {
            File = file;
            ErrorLogger = errorLogger;
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line,
            int charPositionInLine,
            string msg, RecognitionException e)
        {
            Errored = true;
            ErrorLogger.Invoke($"error parsing {File} - {line}:{charPositionInLine}: {msg}");
        }
    }
    
    private class LexerListener : IAntlrErrorListener<int>
    {
        internal bool Errored = false;
        internal Action<string> ErrorLogger;
        internal string File;
        internal LexerListener(string file, Action<string> errorLogger)
        {
            File = file;
            ErrorLogger = errorLogger;
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line,
            int charPositionInLine,
            string msg, RecognitionException e)
        {
            Errored = true;
            ErrorLogger.Invoke($"error lexing {File} - {line}:{charPositionInLine}: {msg}");
        }
    }
    /// <summary>
    /// Loads all patches from a directory
    /// </summary>
    /// <param name="directory"></param>
    /// <param name="modId">The ID of the mod to load the guid as</param>
    public void LoadPatchesInDirectory(DirectoryInfo directory, string modId)
    {
        // MessageLogger.Invoke($"Loading patches from {directory} (modId: {modId})");
        var tokenTransformer = new Transformer(msg => throw new LoadException(msg));
        foreach (var library in directory.EnumerateFiles("_*.patch", SearchOption.AllDirectories))
        {
            LoadSingleLibrary(modId, library, tokenTransformer);
        }

        foreach (var patch in directory.EnumerateFiles("*.patch", SearchOption.AllDirectories))
        {
            LoadSinglePatch(modId, patch, tokenTransformer);
        }
    }

    private void LoadSinglePatch(string modId, FileInfo patch, Transformer tokenTransformer)
    {
        if (patch.Name.StartsWith("_"))
            return;
        try
        {
            MessageLogger.Invoke($"Loading patch {modId}:{patch.Name}");
            var charStream = CharStreams.fromPath(patch.FullName);
            var lexer = new sassy_lexer(charStream);
            var lexerErrorGenerator = new LexerListener($"{modId}:{patch.Name}", _errorLogger);
            lexer.AddErrorListener(lexerErrorGenerator);
            if (lexerErrorGenerator.Errored)
                throw new LoadException("lexer errors detected");
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new sassy_parser(tokenStream);
            var parserErrorGenerator = new ParserListener($"{modId}:{patch.Name}", _errorLogger);
            parser.AddErrorListener(parserErrorGenerator);
            var patchContext = parser.patch();
            if (parserErrorGenerator.Errored)
                throw new LoadException("parser errors detected");
            tokenTransformer.Errored = false;
            // var gEnv = new GlobalEnvironment(this, modId);
            // var env = new Environment(gEnv);
            var ctx = tokenTransformer.Visit(patchContext) as SassyPatch;
            ToRegister.Add((modId, ctx));
            // lib = new SassyPatchLibrary(patch);
        }
        catch (Exception e)
        {
            _errorLogger($"Could not run patch: {modId}:{patch.Name} due to: {e.Message}");
        }
    }

    private void LoadSingleLibrary(string modId, FileInfo library, Transformer tokenTransformer)
    {
        string name = modId + ":" + library.Name.Replace(".patch", "").TrimFirst();
        try
        {
            MessageLogger.Invoke($"Loading library {name}");
            var charStream = CharStreams.fromPath(library.FullName);
            var lexerErrorGenerator = new LexerListener(name, _errorLogger);
            var lexer = new sassy_lexer(charStream);
            lexer.AddErrorListener(lexerErrorGenerator);
            if (lexerErrorGenerator.Errored)
                throw new LoadException("lexer errors detected");
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new sassy_parser(tokenStream);
            var parserErrorGenerator = new ParserListener(name, _errorLogger);
            parser.AddErrorListener(parserErrorGenerator);
            if (parserErrorGenerator.Errored)
                throw new LoadException("parser errors detected");
            var patchContext = parser.patch();
            tokenTransformer.Errored = false;
            var patch = tokenTransformer.Visit(patchContext) as SassyPatch;
            var lib = new SassyPatchLibrary(patch);
            AllLibraries[name] = lib;
        }
        catch (Exception e)
        {
            _errorLogger($"Could not load library: {name} due to: {e.Message}");
        }
    }

    /// <summary>
    /// This registers every patch in the files in the to register list
    /// </summary>
    public void RegisterAllPatches()
    {
        foreach (var (modId, patch) in ToRegister)
        {
            var modBase = AllStages[modId];
            // Lets first extract every single stage
            foreach (var child in patch.Children)
            {
                switch (child)
                {
                    // Stage definitions have to be top level
                    case StageDefinition stageDefinition:
                        AllStages[$"{modId}:{stageDefinition.StageName}"] =
                            stageDefinition.StagePriority * 10 + modBase;
                        break;
                    case GlobalStageDefinition globalStageDefinition:
                        AllStages[$"{modId}:{globalStageDefinition.StageName}"] = globalStageDefinition.StagePriority * 10 + _baseGlobalStage;
                        break;
                }
            }
        }
        foreach (var (modId, patch) in ToRegister)
        {
            var gEnv = new GlobalEnvironment(this, modId);
            var env = new Environment(gEnv);
            patch.ExecuteIn(env);
        }
    }

    public void PatchLabels(params string[] labels)
    {
        LoadedLabels.AddRange(labels);
    }

    private static ulong _baseGlobalStage;

    private void SetupBasePriorities(List<string> modLoadOrder)
    {
        ulong i = 0;
        foreach (var mod in modLoadOrder)
        {
            var stagePriority = i * 10000ul;
            var stagePostPriority = stagePriority + 9995ul;
            AllStages[mod] = stagePriority;
            AllStages[$"{mod}:post"] = stagePostPriority;
            i++;
        }
        _baseGlobalStage = i * 10000ul;
    }
}