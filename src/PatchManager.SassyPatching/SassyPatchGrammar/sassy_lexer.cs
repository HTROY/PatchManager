//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/arall/PatchManager/src/PatchManager.SassyPatching/SassyPatchGrammar\sassy_lexer.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SassyPatchGrammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class sassy_lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COMMENT=1, SPACE=2, USE=3, FUNCTION=4, PRE_IF=5, PRE_ELSE=6, PRE_ELSE_IF=7, 
		MIXIN=8, WHILE=9, SET=10, MERGE=11, REQUIRE=12, REQUIRE_NOT=13, STAGE=14, 
		DEFINE_STAGE=15, INCLUDE=16, RETURN=17, LEFT_BRACE=18, RIGHT_BRACE=19, 
		LEFT_PAREN=20, RIGHT_PAREN=21, LEFT_BRACKET=22, RIGHT_BRACKET=23, SEMICOLON=24, 
		COLON=25, COMMA=26, ADD=27, SUBTRACT=28, MULTIPLY=29, DIVIDE=30, MODULUS=31, 
		NOT=32, GREATER_THAN=33, GREATER_THAN_EQUAL=34, LESSER_THAN=35, LESSER_THAN_EQUAL=36, 
		EQUAL_TO=37, NOT_EQUAL_TO=38, AND=39, OR=40, IF=41, ELSE=42, WITHOUT=43, 
		NONE=44, TRUE=45, FALSE=46, HEX_NUMBER=47, NUMBER=48, STRING=49, DELETE=50, 
		NAME=51, CLASS=52, VARIABLE=53, RULESET=54, ELEMENT=55;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMMENT", "MULTILINE_COMMENT", "LINE_COMMENT", "SPACE", "USE", "FUNCTION", 
		"PRE_IF", "PRE_ELSE", "PRE_ELSE_IF", "MIXIN", "WHILE", "SET", "MERGE", 
		"REQUIRE", "REQUIRE_NOT", "STAGE", "DEFINE_STAGE", "INCLUDE", "RETURN", 
		"LEFT_BRACE", "RIGHT_BRACE", "LEFT_PAREN", "RIGHT_PAREN", "LEFT_BRACKET", 
		"RIGHT_BRACKET", "SEMICOLON", "COLON", "COMMA", "ADD", "SUBTRACT", "MULTIPLY", 
		"DIVIDE", "MODULUS", "NOT", "GREATER_THAN", "GREATER_THAN_EQUAL", "LESSER_THAN", 
		"LESSER_THAN_EQUAL", "EQUAL_TO", "NOT_EQUAL_TO", "AND", "OR", "IF", "ELSE", 
		"WITHOUT", "NONE", "TRUE", "FALSE", "HEX_NUMBER", "NUMBER", "STRING", 
		"DELETE", "SHORT_NUMBER", "LONG_NUMBER", "DIGIT", "HEX_DIGIT", "ESC_SEQ", 
		"OCTAL_ESC", "UNICODE_ESC", "IDENTIFIER", "NAME", "CLASS", "VARIABLE", 
		"RULESET", "ELEMENT"
	};


	public sassy_lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public sassy_lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'@use'", "'@function'", "'@if'", "'@else'", "'@else-if'", 
		"'@mixin'", "'@while'", "'@set'", "'@merge'", "'@require'", "'@require-not'", 
		"'@stage'", "'@define-stage'", "'@include'", "'@return'", "'{'", "'}'", 
		"'('", "')'", "'['", "']'", "';'", "':'", "','", "'+'", "'-'", "'*'", 
		"'/'", "'%'", "'!'", "'>'", "'>='", "'<'", "'<='", "'=='", "'!='", "'and'", 
		"'or'", "'if'", "'else'", "'~'", "'null'", "'true'", "'false'", null, 
		null, null, "'@delete'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMENT", "SPACE", "USE", "FUNCTION", "PRE_IF", "PRE_ELSE", "PRE_ELSE_IF", 
		"MIXIN", "WHILE", "SET", "MERGE", "REQUIRE", "REQUIRE_NOT", "STAGE", "DEFINE_STAGE", 
		"INCLUDE", "RETURN", "LEFT_BRACE", "RIGHT_BRACE", "LEFT_PAREN", "RIGHT_PAREN", 
		"LEFT_BRACKET", "RIGHT_BRACKET", "SEMICOLON", "COLON", "COMMA", "ADD", 
		"SUBTRACT", "MULTIPLY", "DIVIDE", "MODULUS", "NOT", "GREATER_THAN", "GREATER_THAN_EQUAL", 
		"LESSER_THAN", "LESSER_THAN_EQUAL", "EQUAL_TO", "NOT_EQUAL_TO", "AND", 
		"OR", "IF", "ELSE", "WITHOUT", "NONE", "TRUE", "FALSE", "HEX_NUMBER", 
		"NUMBER", "STRING", "DELETE", "NAME", "CLASS", "VARIABLE", "RULESET", 
		"ELEMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "sassy_lexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static sassy_lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,55,496,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,1,0,1,0,3,0,134,8,0,1,0,1,0,1,1,1,1,1,1,1,1,5,1,142,8,1,
		10,1,12,1,145,9,1,1,1,4,1,148,8,1,11,1,12,1,149,1,1,1,1,5,1,154,8,1,10,
		1,12,1,157,9,1,1,1,4,1,160,8,1,11,1,12,1,161,5,1,164,8,1,10,1,12,1,167,
		9,1,1,1,1,1,1,2,1,2,1,2,1,2,5,2,175,8,2,10,2,12,2,178,9,2,1,3,4,3,181,
		8,3,11,3,12,3,182,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,
		1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,
		8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,
		1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,1,12,1,12,
		1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,
		1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,
		1,15,1,15,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,
		1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,
		1,18,1,18,1,18,1,18,1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,22,1,23,
		1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,27,1,27,1,28,1,28,1,29,1,29,1,30,
		1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,1,35,1,35,1,35,1,36,1,36,
		1,37,1,37,1,37,1,38,1,38,1,38,1,39,1,39,1,39,1,40,1,40,1,40,1,40,1,41,
		1,41,1,41,1,42,1,42,1,42,1,43,1,43,1,43,1,43,1,43,1,44,1,44,1,45,1,45,
		1,45,1,45,1,45,1,46,1,46,1,46,1,46,1,46,1,47,1,47,1,47,1,47,1,47,1,47,
		1,48,1,48,1,48,1,48,4,48,390,8,48,11,48,12,48,391,1,49,4,49,395,8,49,11,
		49,12,49,396,1,49,1,49,3,49,401,8,49,1,50,1,50,1,50,5,50,406,8,50,10,50,
		12,50,409,9,50,1,50,1,50,1,50,1,50,5,50,415,8,50,10,50,12,50,418,9,50,
		1,50,3,50,421,8,50,1,51,1,51,1,51,1,51,1,51,1,51,1,51,1,51,1,52,1,52,4,
		52,433,8,52,11,52,12,52,434,1,53,4,53,438,8,53,11,53,12,53,439,1,53,1,
		53,4,53,444,8,53,11,53,12,53,445,1,54,1,54,1,55,1,55,1,56,1,56,1,56,1,
		56,3,56,456,8,56,1,57,1,57,1,57,1,57,1,57,1,57,1,57,1,57,1,57,3,57,467,
		8,57,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,59,1,59,5,59,478,8,59,10,59,
		12,59,481,9,59,1,60,1,60,1,60,1,61,1,61,1,61,1,62,1,62,1,62,1,63,1,63,
		1,63,1,64,1,64,0,0,65,1,1,3,0,5,0,7,2,9,3,11,4,13,5,15,6,17,7,19,8,21,
		9,23,10,25,11,27,12,29,13,31,14,33,15,35,16,37,17,39,18,41,19,43,20,45,
		21,47,22,49,23,51,24,53,25,55,26,57,27,59,28,61,29,63,30,65,31,67,32,69,
		33,71,34,73,35,75,36,77,37,79,38,81,39,83,40,85,41,87,42,89,43,91,44,93,
		45,95,46,97,47,99,48,101,49,103,50,105,0,107,0,109,0,111,0,113,0,115,0,
		117,0,119,0,121,51,123,52,125,53,127,54,129,55,1,0,11,1,0,42,42,2,0,42,
		42,47,47,2,0,10,10,13,13,3,0,9,10,12,13,32,32,2,0,34,34,92,92,2,0,39,39,
		92,92,1,0,48,57,3,0,48,57,65,70,97,102,8,0,34,34,39,39,92,92,98,98,102,
		102,110,110,114,114,116,116,5,0,42,42,63,63,65,90,95,95,97,122,7,0,42,
		42,45,46,48,57,63,63,65,90,95,95,97,122,510,0,1,1,0,0,0,0,7,1,0,0,0,0,
		9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,
		0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,
		31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,
		0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,
		0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,
		1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,
		0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,
		1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,
		0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,121,1,0,0,0,
		0,123,1,0,0,0,0,125,1,0,0,0,0,127,1,0,0,0,0,129,1,0,0,0,1,133,1,0,0,0,
		3,137,1,0,0,0,5,170,1,0,0,0,7,180,1,0,0,0,9,186,1,0,0,0,11,191,1,0,0,0,
		13,201,1,0,0,0,15,205,1,0,0,0,17,211,1,0,0,0,19,220,1,0,0,0,21,227,1,0,
		0,0,23,234,1,0,0,0,25,239,1,0,0,0,27,246,1,0,0,0,29,255,1,0,0,0,31,268,
		1,0,0,0,33,275,1,0,0,0,35,289,1,0,0,0,37,298,1,0,0,0,39,306,1,0,0,0,41,
		308,1,0,0,0,43,310,1,0,0,0,45,312,1,0,0,0,47,314,1,0,0,0,49,316,1,0,0,
		0,51,318,1,0,0,0,53,320,1,0,0,0,55,322,1,0,0,0,57,324,1,0,0,0,59,326,1,
		0,0,0,61,328,1,0,0,0,63,330,1,0,0,0,65,332,1,0,0,0,67,334,1,0,0,0,69,336,
		1,0,0,0,71,338,1,0,0,0,73,341,1,0,0,0,75,343,1,0,0,0,77,346,1,0,0,0,79,
		349,1,0,0,0,81,352,1,0,0,0,83,356,1,0,0,0,85,359,1,0,0,0,87,362,1,0,0,
		0,89,367,1,0,0,0,91,369,1,0,0,0,93,374,1,0,0,0,95,379,1,0,0,0,97,385,1,
		0,0,0,99,400,1,0,0,0,101,420,1,0,0,0,103,422,1,0,0,0,105,430,1,0,0,0,107,
		437,1,0,0,0,109,447,1,0,0,0,111,449,1,0,0,0,113,455,1,0,0,0,115,466,1,
		0,0,0,117,468,1,0,0,0,119,475,1,0,0,0,121,482,1,0,0,0,123,485,1,0,0,0,
		125,488,1,0,0,0,127,491,1,0,0,0,129,494,1,0,0,0,131,134,3,5,2,0,132,134,
		3,3,1,0,133,131,1,0,0,0,133,132,1,0,0,0,134,135,1,0,0,0,135,136,6,0,0,
		0,136,2,1,0,0,0,137,138,5,47,0,0,138,139,5,42,0,0,139,143,1,0,0,0,140,
		142,8,0,0,0,141,140,1,0,0,0,142,145,1,0,0,0,143,141,1,0,0,0,143,144,1,
		0,0,0,144,147,1,0,0,0,145,143,1,0,0,0,146,148,5,42,0,0,147,146,1,0,0,0,
		148,149,1,0,0,0,149,147,1,0,0,0,149,150,1,0,0,0,150,165,1,0,0,0,151,155,
		8,1,0,0,152,154,8,0,0,0,153,152,1,0,0,0,154,157,1,0,0,0,155,153,1,0,0,
		0,155,156,1,0,0,0,156,159,1,0,0,0,157,155,1,0,0,0,158,160,5,42,0,0,159,
		158,1,0,0,0,160,161,1,0,0,0,161,159,1,0,0,0,161,162,1,0,0,0,162,164,1,
		0,0,0,163,151,1,0,0,0,164,167,1,0,0,0,165,163,1,0,0,0,165,166,1,0,0,0,
		166,168,1,0,0,0,167,165,1,0,0,0,168,169,5,47,0,0,169,4,1,0,0,0,170,171,
		5,47,0,0,171,172,5,47,0,0,172,176,1,0,0,0,173,175,8,2,0,0,174,173,1,0,
		0,0,175,178,1,0,0,0,176,174,1,0,0,0,176,177,1,0,0,0,177,6,1,0,0,0,178,
		176,1,0,0,0,179,181,7,3,0,0,180,179,1,0,0,0,181,182,1,0,0,0,182,180,1,
		0,0,0,182,183,1,0,0,0,183,184,1,0,0,0,184,185,6,3,0,0,185,8,1,0,0,0,186,
		187,5,64,0,0,187,188,5,117,0,0,188,189,5,115,0,0,189,190,5,101,0,0,190,
		10,1,0,0,0,191,192,5,64,0,0,192,193,5,102,0,0,193,194,5,117,0,0,194,195,
		5,110,0,0,195,196,5,99,0,0,196,197,5,116,0,0,197,198,5,105,0,0,198,199,
		5,111,0,0,199,200,5,110,0,0,200,12,1,0,0,0,201,202,5,64,0,0,202,203,5,
		105,0,0,203,204,5,102,0,0,204,14,1,0,0,0,205,206,5,64,0,0,206,207,5,101,
		0,0,207,208,5,108,0,0,208,209,5,115,0,0,209,210,5,101,0,0,210,16,1,0,0,
		0,211,212,5,64,0,0,212,213,5,101,0,0,213,214,5,108,0,0,214,215,5,115,0,
		0,215,216,5,101,0,0,216,217,5,45,0,0,217,218,5,105,0,0,218,219,5,102,0,
		0,219,18,1,0,0,0,220,221,5,64,0,0,221,222,5,109,0,0,222,223,5,105,0,0,
		223,224,5,120,0,0,224,225,5,105,0,0,225,226,5,110,0,0,226,20,1,0,0,0,227,
		228,5,64,0,0,228,229,5,119,0,0,229,230,5,104,0,0,230,231,5,105,0,0,231,
		232,5,108,0,0,232,233,5,101,0,0,233,22,1,0,0,0,234,235,5,64,0,0,235,236,
		5,115,0,0,236,237,5,101,0,0,237,238,5,116,0,0,238,24,1,0,0,0,239,240,5,
		64,0,0,240,241,5,109,0,0,241,242,5,101,0,0,242,243,5,114,0,0,243,244,5,
		103,0,0,244,245,5,101,0,0,245,26,1,0,0,0,246,247,5,64,0,0,247,248,5,114,
		0,0,248,249,5,101,0,0,249,250,5,113,0,0,250,251,5,117,0,0,251,252,5,105,
		0,0,252,253,5,114,0,0,253,254,5,101,0,0,254,28,1,0,0,0,255,256,5,64,0,
		0,256,257,5,114,0,0,257,258,5,101,0,0,258,259,5,113,0,0,259,260,5,117,
		0,0,260,261,5,105,0,0,261,262,5,114,0,0,262,263,5,101,0,0,263,264,5,45,
		0,0,264,265,5,110,0,0,265,266,5,111,0,0,266,267,5,116,0,0,267,30,1,0,0,
		0,268,269,5,64,0,0,269,270,5,115,0,0,270,271,5,116,0,0,271,272,5,97,0,
		0,272,273,5,103,0,0,273,274,5,101,0,0,274,32,1,0,0,0,275,276,5,64,0,0,
		276,277,5,100,0,0,277,278,5,101,0,0,278,279,5,102,0,0,279,280,5,105,0,
		0,280,281,5,110,0,0,281,282,5,101,0,0,282,283,5,45,0,0,283,284,5,115,0,
		0,284,285,5,116,0,0,285,286,5,97,0,0,286,287,5,103,0,0,287,288,5,101,0,
		0,288,34,1,0,0,0,289,290,5,64,0,0,290,291,5,105,0,0,291,292,5,110,0,0,
		292,293,5,99,0,0,293,294,5,108,0,0,294,295,5,117,0,0,295,296,5,100,0,0,
		296,297,5,101,0,0,297,36,1,0,0,0,298,299,5,64,0,0,299,300,5,114,0,0,300,
		301,5,101,0,0,301,302,5,116,0,0,302,303,5,117,0,0,303,304,5,114,0,0,304,
		305,5,110,0,0,305,38,1,0,0,0,306,307,5,123,0,0,307,40,1,0,0,0,308,309,
		5,125,0,0,309,42,1,0,0,0,310,311,5,40,0,0,311,44,1,0,0,0,312,313,5,41,
		0,0,313,46,1,0,0,0,314,315,5,91,0,0,315,48,1,0,0,0,316,317,5,93,0,0,317,
		50,1,0,0,0,318,319,5,59,0,0,319,52,1,0,0,0,320,321,5,58,0,0,321,54,1,0,
		0,0,322,323,5,44,0,0,323,56,1,0,0,0,324,325,5,43,0,0,325,58,1,0,0,0,326,
		327,5,45,0,0,327,60,1,0,0,0,328,329,5,42,0,0,329,62,1,0,0,0,330,331,5,
		47,0,0,331,64,1,0,0,0,332,333,5,37,0,0,333,66,1,0,0,0,334,335,5,33,0,0,
		335,68,1,0,0,0,336,337,5,62,0,0,337,70,1,0,0,0,338,339,5,62,0,0,339,340,
		5,61,0,0,340,72,1,0,0,0,341,342,5,60,0,0,342,74,1,0,0,0,343,344,5,60,0,
		0,344,345,5,61,0,0,345,76,1,0,0,0,346,347,5,61,0,0,347,348,5,61,0,0,348,
		78,1,0,0,0,349,350,5,33,0,0,350,351,5,61,0,0,351,80,1,0,0,0,352,353,5,
		97,0,0,353,354,5,110,0,0,354,355,5,100,0,0,355,82,1,0,0,0,356,357,5,111,
		0,0,357,358,5,114,0,0,358,84,1,0,0,0,359,360,5,105,0,0,360,361,5,102,0,
		0,361,86,1,0,0,0,362,363,5,101,0,0,363,364,5,108,0,0,364,365,5,115,0,0,
		365,366,5,101,0,0,366,88,1,0,0,0,367,368,5,126,0,0,368,90,1,0,0,0,369,
		370,5,110,0,0,370,371,5,117,0,0,371,372,5,108,0,0,372,373,5,108,0,0,373,
		92,1,0,0,0,374,375,5,116,0,0,375,376,5,114,0,0,376,377,5,117,0,0,377,378,
		5,101,0,0,378,94,1,0,0,0,379,380,5,102,0,0,380,381,5,97,0,0,381,382,5,
		108,0,0,382,383,5,115,0,0,383,384,5,101,0,0,384,96,1,0,0,0,385,386,5,48,
		0,0,386,387,5,120,0,0,387,389,1,0,0,0,388,390,3,111,55,0,389,388,1,0,0,
		0,390,391,1,0,0,0,391,389,1,0,0,0,391,392,1,0,0,0,392,98,1,0,0,0,393,395,
		3,109,54,0,394,393,1,0,0,0,395,396,1,0,0,0,396,394,1,0,0,0,396,397,1,0,
		0,0,397,401,1,0,0,0,398,401,3,105,52,0,399,401,3,107,53,0,400,394,1,0,
		0,0,400,398,1,0,0,0,400,399,1,0,0,0,401,100,1,0,0,0,402,407,5,34,0,0,403,
		406,3,113,56,0,404,406,8,4,0,0,405,403,1,0,0,0,405,404,1,0,0,0,406,409,
		1,0,0,0,407,405,1,0,0,0,407,408,1,0,0,0,408,410,1,0,0,0,409,407,1,0,0,
		0,410,421,5,34,0,0,411,416,5,39,0,0,412,415,3,113,56,0,413,415,8,5,0,0,
		414,412,1,0,0,0,414,413,1,0,0,0,415,418,1,0,0,0,416,414,1,0,0,0,416,417,
		1,0,0,0,417,419,1,0,0,0,418,416,1,0,0,0,419,421,5,39,0,0,420,402,1,0,0,
		0,420,411,1,0,0,0,421,102,1,0,0,0,422,423,5,64,0,0,423,424,5,100,0,0,424,
		425,5,101,0,0,425,426,5,108,0,0,426,427,5,101,0,0,427,428,5,116,0,0,428,
		429,5,101,0,0,429,104,1,0,0,0,430,432,5,46,0,0,431,433,3,109,54,0,432,
		431,1,0,0,0,433,434,1,0,0,0,434,432,1,0,0,0,434,435,1,0,0,0,435,106,1,
		0,0,0,436,438,3,109,54,0,437,436,1,0,0,0,438,439,1,0,0,0,439,437,1,0,0,
		0,439,440,1,0,0,0,440,441,1,0,0,0,441,443,5,46,0,0,442,444,3,109,54,0,
		443,442,1,0,0,0,444,445,1,0,0,0,445,443,1,0,0,0,445,446,1,0,0,0,446,108,
		1,0,0,0,447,448,7,6,0,0,448,110,1,0,0,0,449,450,7,7,0,0,450,112,1,0,0,
		0,451,452,5,92,0,0,452,456,7,8,0,0,453,456,3,117,58,0,454,456,3,115,57,
		0,455,451,1,0,0,0,455,453,1,0,0,0,455,454,1,0,0,0,456,114,1,0,0,0,457,
		458,5,92,0,0,458,459,2,48,51,0,459,460,2,48,55,0,460,467,2,48,55,0,461,
		462,5,92,0,0,462,463,2,48,55,0,463,467,2,48,55,0,464,465,5,92,0,0,465,
		467,2,48,55,0,466,457,1,0,0,0,466,461,1,0,0,0,466,464,1,0,0,0,467,116,
		1,0,0,0,468,469,5,92,0,0,469,470,5,117,0,0,470,471,3,111,55,0,471,472,
		3,111,55,0,472,473,3,111,55,0,473,474,3,111,55,0,474,118,1,0,0,0,475,479,
		7,9,0,0,476,478,7,10,0,0,477,476,1,0,0,0,478,481,1,0,0,0,479,477,1,0,0,
		0,479,480,1,0,0,0,480,120,1,0,0,0,481,479,1,0,0,0,482,483,5,35,0,0,483,
		484,3,119,59,0,484,122,1,0,0,0,485,486,5,46,0,0,486,487,3,119,59,0,487,
		124,1,0,0,0,488,489,5,36,0,0,489,490,3,119,59,0,490,126,1,0,0,0,491,492,
		5,58,0,0,492,493,3,119,59,0,493,128,1,0,0,0,494,495,3,119,59,0,495,130,
		1,0,0,0,23,0,133,143,149,155,161,165,176,182,391,396,400,405,407,414,416,
		420,434,439,445,455,466,479,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace SassyPatchGrammar
