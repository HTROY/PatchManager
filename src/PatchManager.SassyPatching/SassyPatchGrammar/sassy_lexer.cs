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
		MIXIN=8, WHILE=9, FOR=10, FROM=11, THROUGH=12, TO=13, EACH=14, IN=15, 
		SET=16, MERGE=17, REQUIRE=18, STAGE=19, DEFINE_STAGE=20, INCLUDE=21, RETURN=22, 
		PATCH=23, NEW=24, BEFORE=25, AFTER=26, GLOBAL=27, LEFT_BRACE=28, RIGHT_BRACE=29, 
		LEFT_PAREN=30, RIGHT_PAREN=31, LEFT_BRACKET=32, RIGHT_BRACKET=33, SEMICOLON=34, 
		COLON=35, COMMA=36, ADD=37, SUBTRACT=38, MULTIPLY=39, DIVIDE=40, MODULUS=41, 
		NOT=42, GREATER_THAN=43, GREATER_THAN_EQUAL=44, LESSER_THAN=45, LESSER_THAN_EQUAL=46, 
		EQUAL_TO=47, NOT_EQUAL_TO=48, AND=49, OR=50, IF=51, ELSE=52, WITHOUT=53, 
		NONE=54, TRUE=55, FALSE=56, HEX_NUMBER=57, NUMBER=58, STRING=59, DELETE=60, 
		NAME=61, CLASS=62, VARIABLE=63, LOCALVARIABLE=64, RULESET=65, ENSURE=66, 
		ELEMENT=67;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMMENT", "MULTILINE_COMMENT", "LINE_COMMENT", "SPACE", "USE", "FUNCTION", 
		"PRE_IF", "PRE_ELSE", "PRE_ELSE_IF", "MIXIN", "WHILE", "FOR", "FROM", 
		"THROUGH", "TO", "EACH", "IN", "SET", "MERGE", "REQUIRE", "STAGE", "DEFINE_STAGE", 
		"INCLUDE", "RETURN", "PATCH", "NEW", "BEFORE", "AFTER", "GLOBAL", "LEFT_BRACE", 
		"RIGHT_BRACE", "LEFT_PAREN", "RIGHT_PAREN", "LEFT_BRACKET", "RIGHT_BRACKET", 
		"SEMICOLON", "COLON", "COMMA", "ADD", "SUBTRACT", "MULTIPLY", "DIVIDE", 
		"MODULUS", "NOT", "GREATER_THAN", "GREATER_THAN_EQUAL", "LESSER_THAN", 
		"LESSER_THAN_EQUAL", "EQUAL_TO", "NOT_EQUAL_TO", "AND", "OR", "IF", "ELSE", 
		"WITHOUT", "NONE", "TRUE", "FALSE", "HEX_NUMBER", "NUMBER", "STRING", 
		"DELETE", "SHORT_NUMBER", "LONG_NUMBER", "DIGIT", "HEX_DIGIT", "ESC_SEQ", 
		"OCTAL_ESC", "UNICODE_ESC", "IDENTIFIER", "WILDCARDLESS_IDENTIFIER", "NAME", 
		"CLASS", "VARIABLE", "LOCALVARIABLE", "RULESET", "ENSURE", "ELEMENT"
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
		"'@mixin'", "'@while'", "'@for'", "'from'", "'through'", "'to'", "'@each'", 
		"'in'", "'@set'", "'@merge'", "'@require'", "'@stage'", "'@define-stage'", 
		"'@include'", "'@return'", "'@patch'", "'@new'", "'@before'", "'@after'", 
		"'@global'", "'{'", "'}'", "'('", "')'", "'['", "']'", "';'", "':'", "','", 
		"'+'", "'-'", "'*'", "'/'", "'%'", "'not'", "'>'", "'>='", "'<'", "'<='", 
		"'=='", "'!='", "'and'", "'or'", "'if'", "'else'", "'~'", "'null'", "'true'", 
		"'false'", null, null, null, "'@delete'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMENT", "SPACE", "USE", "FUNCTION", "PRE_IF", "PRE_ELSE", "PRE_ELSE_IF", 
		"MIXIN", "WHILE", "FOR", "FROM", "THROUGH", "TO", "EACH", "IN", "SET", 
		"MERGE", "REQUIRE", "STAGE", "DEFINE_STAGE", "INCLUDE", "RETURN", "PATCH", 
		"NEW", "BEFORE", "AFTER", "GLOBAL", "LEFT_BRACE", "RIGHT_BRACE", "LEFT_PAREN", 
		"RIGHT_PAREN", "LEFT_BRACKET", "RIGHT_BRACKET", "SEMICOLON", "COLON", 
		"COMMA", "ADD", "SUBTRACT", "MULTIPLY", "DIVIDE", "MODULUS", "NOT", "GREATER_THAN", 
		"GREATER_THAN_EQUAL", "LESSER_THAN", "LESSER_THAN_EQUAL", "EQUAL_TO", 
		"NOT_EQUAL_TO", "AND", "OR", "IF", "ELSE", "WITHOUT", "NONE", "TRUE", 
		"FALSE", "HEX_NUMBER", "NUMBER", "STRING", "DELETE", "NAME", "CLASS", 
		"VARIABLE", "LOCALVARIABLE", "RULESET", "ENSURE", "ELEMENT"
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
		4,0,67,595,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,7,76,2,77,
		7,77,1,0,1,0,3,0,160,8,0,1,0,1,0,1,1,1,1,1,1,1,1,5,1,168,8,1,10,1,12,1,
		171,9,1,1,1,4,1,174,8,1,11,1,12,1,175,1,1,1,1,5,1,180,8,1,10,1,12,1,183,
		9,1,1,1,4,1,186,8,1,11,1,12,1,187,5,1,190,8,1,10,1,12,1,193,9,1,1,1,1,
		1,1,2,1,2,1,2,1,2,5,2,201,8,2,10,2,12,2,204,9,2,1,3,4,3,207,8,3,11,3,12,
		3,208,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,
		1,5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,
		8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,
		10,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,
		13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,
		16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,18,1,
		18,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,
		20,1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,
		21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,23,1,23,1,
		23,1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,25,1,
		25,1,25,1,25,1,25,1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,
		27,1,27,1,27,1,27,1,27,1,28,1,28,1,28,1,28,1,28,1,28,1,28,1,28,1,29,1,
		29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,1,35,1,35,1,36,1,
		36,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,1,42,1,42,1,43,1,
		43,1,43,1,43,1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,47,1,47,1,47,1,48,1,
		48,1,48,1,49,1,49,1,49,1,50,1,50,1,50,1,50,1,51,1,51,1,51,1,52,1,52,1,
		52,1,53,1,53,1,53,1,53,1,53,1,54,1,54,1,55,1,55,1,55,1,55,1,55,1,56,1,
		56,1,56,1,56,1,56,1,57,1,57,1,57,1,57,1,57,1,57,1,58,1,58,1,58,1,58,4,
		58,470,8,58,11,58,12,58,471,1,59,4,59,475,8,59,11,59,12,59,476,1,59,1,
		59,3,59,481,8,59,1,60,1,60,1,60,5,60,486,8,60,10,60,12,60,489,9,60,1,60,
		1,60,1,60,1,60,5,60,495,8,60,10,60,12,60,498,9,60,1,60,3,60,501,8,60,1,
		61,1,61,1,61,1,61,1,61,1,61,1,61,1,61,1,62,1,62,4,62,513,8,62,11,62,12,
		62,514,1,63,4,63,518,8,63,11,63,12,63,519,1,63,1,63,4,63,524,8,63,11,63,
		12,63,525,1,64,1,64,1,65,1,65,1,66,1,66,1,66,1,66,3,66,536,8,66,1,67,1,
		67,1,67,1,67,1,67,1,67,1,67,1,67,1,67,3,67,547,8,67,1,68,1,68,1,68,1,68,
		1,68,1,68,1,68,1,69,1,69,1,69,1,69,5,69,560,8,69,10,69,12,69,563,9,69,
		1,70,1,70,1,70,1,70,5,70,569,8,70,10,70,12,70,572,9,70,1,71,1,71,1,71,
		1,72,1,72,1,72,1,73,1,73,1,73,1,74,1,74,1,74,1,74,1,74,1,75,1,75,1,75,
		1,76,1,76,1,76,1,77,1,77,0,0,78,1,1,3,0,5,0,7,2,9,3,11,4,13,5,15,6,17,
		7,19,8,21,9,23,10,25,11,27,12,29,13,31,14,33,15,35,16,37,17,39,18,41,19,
		43,20,45,21,47,22,49,23,51,24,53,25,55,26,57,27,59,28,61,29,63,30,65,31,
		67,32,69,33,71,34,73,35,75,36,77,37,79,38,81,39,83,40,85,41,87,42,89,43,
		91,44,93,45,95,46,97,47,99,48,101,49,103,50,105,51,107,52,109,53,111,54,
		113,55,115,56,117,57,119,58,121,59,123,60,125,0,127,0,129,0,131,0,133,
		0,135,0,137,0,139,0,141,0,143,61,145,62,147,63,149,64,151,65,153,66,155,
		67,1,0,16,1,0,42,42,2,0,42,42,47,47,2,0,10,10,13,13,3,0,9,10,12,13,32,
		32,2,0,34,34,92,92,2,0,39,39,92,92,1,0,48,57,3,0,48,57,65,70,97,102,8,
		0,34,34,39,39,92,92,98,98,102,102,110,110,114,114,116,116,5,0,42,42,63,
		63,65,90,95,95,97,122,7,0,42,42,46,46,48,57,63,63,65,90,95,95,97,122,1,
		0,45,45,6,0,42,42,46,46,63,63,65,90,95,95,97,122,3,0,65,90,95,95,97,122,
		5,0,46,46,48,57,65,90,95,95,97,122,4,0,46,46,65,90,95,95,97,122,611,0,
		1,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,
		0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,
		1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,
		0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,
		1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,
		0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,
		1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,
		0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,
		1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,
		0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,
		0,0,0,115,1,0,0,0,0,117,1,0,0,0,0,119,1,0,0,0,0,121,1,0,0,0,0,123,1,0,
		0,0,0,143,1,0,0,0,0,145,1,0,0,0,0,147,1,0,0,0,0,149,1,0,0,0,0,151,1,0,
		0,0,0,153,1,0,0,0,0,155,1,0,0,0,1,159,1,0,0,0,3,163,1,0,0,0,5,196,1,0,
		0,0,7,206,1,0,0,0,9,212,1,0,0,0,11,217,1,0,0,0,13,227,1,0,0,0,15,231,1,
		0,0,0,17,237,1,0,0,0,19,246,1,0,0,0,21,253,1,0,0,0,23,260,1,0,0,0,25,265,
		1,0,0,0,27,270,1,0,0,0,29,278,1,0,0,0,31,281,1,0,0,0,33,287,1,0,0,0,35,
		290,1,0,0,0,37,295,1,0,0,0,39,302,1,0,0,0,41,311,1,0,0,0,43,318,1,0,0,
		0,45,332,1,0,0,0,47,341,1,0,0,0,49,349,1,0,0,0,51,356,1,0,0,0,53,361,1,
		0,0,0,55,369,1,0,0,0,57,376,1,0,0,0,59,384,1,0,0,0,61,386,1,0,0,0,63,388,
		1,0,0,0,65,390,1,0,0,0,67,392,1,0,0,0,69,394,1,0,0,0,71,396,1,0,0,0,73,
		398,1,0,0,0,75,400,1,0,0,0,77,402,1,0,0,0,79,404,1,0,0,0,81,406,1,0,0,
		0,83,408,1,0,0,0,85,410,1,0,0,0,87,412,1,0,0,0,89,416,1,0,0,0,91,418,1,
		0,0,0,93,421,1,0,0,0,95,423,1,0,0,0,97,426,1,0,0,0,99,429,1,0,0,0,101,
		432,1,0,0,0,103,436,1,0,0,0,105,439,1,0,0,0,107,442,1,0,0,0,109,447,1,
		0,0,0,111,449,1,0,0,0,113,454,1,0,0,0,115,459,1,0,0,0,117,465,1,0,0,0,
		119,480,1,0,0,0,121,500,1,0,0,0,123,502,1,0,0,0,125,510,1,0,0,0,127,517,
		1,0,0,0,129,527,1,0,0,0,131,529,1,0,0,0,133,535,1,0,0,0,135,546,1,0,0,
		0,137,548,1,0,0,0,139,555,1,0,0,0,141,564,1,0,0,0,143,573,1,0,0,0,145,
		576,1,0,0,0,147,579,1,0,0,0,149,582,1,0,0,0,151,587,1,0,0,0,153,590,1,
		0,0,0,155,593,1,0,0,0,157,160,3,5,2,0,158,160,3,3,1,0,159,157,1,0,0,0,
		159,158,1,0,0,0,160,161,1,0,0,0,161,162,6,0,0,0,162,2,1,0,0,0,163,164,
		5,47,0,0,164,165,5,42,0,0,165,169,1,0,0,0,166,168,8,0,0,0,167,166,1,0,
		0,0,168,171,1,0,0,0,169,167,1,0,0,0,169,170,1,0,0,0,170,173,1,0,0,0,171,
		169,1,0,0,0,172,174,5,42,0,0,173,172,1,0,0,0,174,175,1,0,0,0,175,173,1,
		0,0,0,175,176,1,0,0,0,176,191,1,0,0,0,177,181,8,1,0,0,178,180,8,0,0,0,
		179,178,1,0,0,0,180,183,1,0,0,0,181,179,1,0,0,0,181,182,1,0,0,0,182,185,
		1,0,0,0,183,181,1,0,0,0,184,186,5,42,0,0,185,184,1,0,0,0,186,187,1,0,0,
		0,187,185,1,0,0,0,187,188,1,0,0,0,188,190,1,0,0,0,189,177,1,0,0,0,190,
		193,1,0,0,0,191,189,1,0,0,0,191,192,1,0,0,0,192,194,1,0,0,0,193,191,1,
		0,0,0,194,195,5,47,0,0,195,4,1,0,0,0,196,197,5,47,0,0,197,198,5,47,0,0,
		198,202,1,0,0,0,199,201,8,2,0,0,200,199,1,0,0,0,201,204,1,0,0,0,202,200,
		1,0,0,0,202,203,1,0,0,0,203,6,1,0,0,0,204,202,1,0,0,0,205,207,7,3,0,0,
		206,205,1,0,0,0,207,208,1,0,0,0,208,206,1,0,0,0,208,209,1,0,0,0,209,210,
		1,0,0,0,210,211,6,3,0,0,211,8,1,0,0,0,212,213,5,64,0,0,213,214,5,117,0,
		0,214,215,5,115,0,0,215,216,5,101,0,0,216,10,1,0,0,0,217,218,5,64,0,0,
		218,219,5,102,0,0,219,220,5,117,0,0,220,221,5,110,0,0,221,222,5,99,0,0,
		222,223,5,116,0,0,223,224,5,105,0,0,224,225,5,111,0,0,225,226,5,110,0,
		0,226,12,1,0,0,0,227,228,5,64,0,0,228,229,5,105,0,0,229,230,5,102,0,0,
		230,14,1,0,0,0,231,232,5,64,0,0,232,233,5,101,0,0,233,234,5,108,0,0,234,
		235,5,115,0,0,235,236,5,101,0,0,236,16,1,0,0,0,237,238,5,64,0,0,238,239,
		5,101,0,0,239,240,5,108,0,0,240,241,5,115,0,0,241,242,5,101,0,0,242,243,
		5,45,0,0,243,244,5,105,0,0,244,245,5,102,0,0,245,18,1,0,0,0,246,247,5,
		64,0,0,247,248,5,109,0,0,248,249,5,105,0,0,249,250,5,120,0,0,250,251,5,
		105,0,0,251,252,5,110,0,0,252,20,1,0,0,0,253,254,5,64,0,0,254,255,5,119,
		0,0,255,256,5,104,0,0,256,257,5,105,0,0,257,258,5,108,0,0,258,259,5,101,
		0,0,259,22,1,0,0,0,260,261,5,64,0,0,261,262,5,102,0,0,262,263,5,111,0,
		0,263,264,5,114,0,0,264,24,1,0,0,0,265,266,5,102,0,0,266,267,5,114,0,0,
		267,268,5,111,0,0,268,269,5,109,0,0,269,26,1,0,0,0,270,271,5,116,0,0,271,
		272,5,104,0,0,272,273,5,114,0,0,273,274,5,111,0,0,274,275,5,117,0,0,275,
		276,5,103,0,0,276,277,5,104,0,0,277,28,1,0,0,0,278,279,5,116,0,0,279,280,
		5,111,0,0,280,30,1,0,0,0,281,282,5,64,0,0,282,283,5,101,0,0,283,284,5,
		97,0,0,284,285,5,99,0,0,285,286,5,104,0,0,286,32,1,0,0,0,287,288,5,105,
		0,0,288,289,5,110,0,0,289,34,1,0,0,0,290,291,5,64,0,0,291,292,5,115,0,
		0,292,293,5,101,0,0,293,294,5,116,0,0,294,36,1,0,0,0,295,296,5,64,0,0,
		296,297,5,109,0,0,297,298,5,101,0,0,298,299,5,114,0,0,299,300,5,103,0,
		0,300,301,5,101,0,0,301,38,1,0,0,0,302,303,5,64,0,0,303,304,5,114,0,0,
		304,305,5,101,0,0,305,306,5,113,0,0,306,307,5,117,0,0,307,308,5,105,0,
		0,308,309,5,114,0,0,309,310,5,101,0,0,310,40,1,0,0,0,311,312,5,64,0,0,
		312,313,5,115,0,0,313,314,5,116,0,0,314,315,5,97,0,0,315,316,5,103,0,0,
		316,317,5,101,0,0,317,42,1,0,0,0,318,319,5,64,0,0,319,320,5,100,0,0,320,
		321,5,101,0,0,321,322,5,102,0,0,322,323,5,105,0,0,323,324,5,110,0,0,324,
		325,5,101,0,0,325,326,5,45,0,0,326,327,5,115,0,0,327,328,5,116,0,0,328,
		329,5,97,0,0,329,330,5,103,0,0,330,331,5,101,0,0,331,44,1,0,0,0,332,333,
		5,64,0,0,333,334,5,105,0,0,334,335,5,110,0,0,335,336,5,99,0,0,336,337,
		5,108,0,0,337,338,5,117,0,0,338,339,5,100,0,0,339,340,5,101,0,0,340,46,
		1,0,0,0,341,342,5,64,0,0,342,343,5,114,0,0,343,344,5,101,0,0,344,345,5,
		116,0,0,345,346,5,117,0,0,346,347,5,114,0,0,347,348,5,110,0,0,348,48,1,
		0,0,0,349,350,5,64,0,0,350,351,5,112,0,0,351,352,5,97,0,0,352,353,5,116,
		0,0,353,354,5,99,0,0,354,355,5,104,0,0,355,50,1,0,0,0,356,357,5,64,0,0,
		357,358,5,110,0,0,358,359,5,101,0,0,359,360,5,119,0,0,360,52,1,0,0,0,361,
		362,5,64,0,0,362,363,5,98,0,0,363,364,5,101,0,0,364,365,5,102,0,0,365,
		366,5,111,0,0,366,367,5,114,0,0,367,368,5,101,0,0,368,54,1,0,0,0,369,370,
		5,64,0,0,370,371,5,97,0,0,371,372,5,102,0,0,372,373,5,116,0,0,373,374,
		5,101,0,0,374,375,5,114,0,0,375,56,1,0,0,0,376,377,5,64,0,0,377,378,5,
		103,0,0,378,379,5,108,0,0,379,380,5,111,0,0,380,381,5,98,0,0,381,382,5,
		97,0,0,382,383,5,108,0,0,383,58,1,0,0,0,384,385,5,123,0,0,385,60,1,0,0,
		0,386,387,5,125,0,0,387,62,1,0,0,0,388,389,5,40,0,0,389,64,1,0,0,0,390,
		391,5,41,0,0,391,66,1,0,0,0,392,393,5,91,0,0,393,68,1,0,0,0,394,395,5,
		93,0,0,395,70,1,0,0,0,396,397,5,59,0,0,397,72,1,0,0,0,398,399,5,58,0,0,
		399,74,1,0,0,0,400,401,5,44,0,0,401,76,1,0,0,0,402,403,5,43,0,0,403,78,
		1,0,0,0,404,405,5,45,0,0,405,80,1,0,0,0,406,407,5,42,0,0,407,82,1,0,0,
		0,408,409,5,47,0,0,409,84,1,0,0,0,410,411,5,37,0,0,411,86,1,0,0,0,412,
		413,5,110,0,0,413,414,5,111,0,0,414,415,5,116,0,0,415,88,1,0,0,0,416,417,
		5,62,0,0,417,90,1,0,0,0,418,419,5,62,0,0,419,420,5,61,0,0,420,92,1,0,0,
		0,421,422,5,60,0,0,422,94,1,0,0,0,423,424,5,60,0,0,424,425,5,61,0,0,425,
		96,1,0,0,0,426,427,5,61,0,0,427,428,5,61,0,0,428,98,1,0,0,0,429,430,5,
		33,0,0,430,431,5,61,0,0,431,100,1,0,0,0,432,433,5,97,0,0,433,434,5,110,
		0,0,434,435,5,100,0,0,435,102,1,0,0,0,436,437,5,111,0,0,437,438,5,114,
		0,0,438,104,1,0,0,0,439,440,5,105,0,0,440,441,5,102,0,0,441,106,1,0,0,
		0,442,443,5,101,0,0,443,444,5,108,0,0,444,445,5,115,0,0,445,446,5,101,
		0,0,446,108,1,0,0,0,447,448,5,126,0,0,448,110,1,0,0,0,449,450,5,110,0,
		0,450,451,5,117,0,0,451,452,5,108,0,0,452,453,5,108,0,0,453,112,1,0,0,
		0,454,455,5,116,0,0,455,456,5,114,0,0,456,457,5,117,0,0,457,458,5,101,
		0,0,458,114,1,0,0,0,459,460,5,102,0,0,460,461,5,97,0,0,461,462,5,108,0,
		0,462,463,5,115,0,0,463,464,5,101,0,0,464,116,1,0,0,0,465,466,5,48,0,0,
		466,467,5,120,0,0,467,469,1,0,0,0,468,470,3,131,65,0,469,468,1,0,0,0,470,
		471,1,0,0,0,471,469,1,0,0,0,471,472,1,0,0,0,472,118,1,0,0,0,473,475,3,
		129,64,0,474,473,1,0,0,0,475,476,1,0,0,0,476,474,1,0,0,0,476,477,1,0,0,
		0,477,481,1,0,0,0,478,481,3,125,62,0,479,481,3,127,63,0,480,474,1,0,0,
		0,480,478,1,0,0,0,480,479,1,0,0,0,481,120,1,0,0,0,482,487,5,34,0,0,483,
		486,3,133,66,0,484,486,8,4,0,0,485,483,1,0,0,0,485,484,1,0,0,0,486,489,
		1,0,0,0,487,485,1,0,0,0,487,488,1,0,0,0,488,490,1,0,0,0,489,487,1,0,0,
		0,490,501,5,34,0,0,491,496,5,39,0,0,492,495,3,133,66,0,493,495,8,5,0,0,
		494,492,1,0,0,0,494,493,1,0,0,0,495,498,1,0,0,0,496,494,1,0,0,0,496,497,
		1,0,0,0,497,499,1,0,0,0,498,496,1,0,0,0,499,501,5,39,0,0,500,482,1,0,0,
		0,500,491,1,0,0,0,501,122,1,0,0,0,502,503,5,64,0,0,503,504,5,100,0,0,504,
		505,5,101,0,0,505,506,5,108,0,0,506,507,5,101,0,0,507,508,5,116,0,0,508,
		509,5,101,0,0,509,124,1,0,0,0,510,512,5,46,0,0,511,513,3,129,64,0,512,
		511,1,0,0,0,513,514,1,0,0,0,514,512,1,0,0,0,514,515,1,0,0,0,515,126,1,
		0,0,0,516,518,3,129,64,0,517,516,1,0,0,0,518,519,1,0,0,0,519,517,1,0,0,
		0,519,520,1,0,0,0,520,521,1,0,0,0,521,523,5,46,0,0,522,524,3,129,64,0,
		523,522,1,0,0,0,524,525,1,0,0,0,525,523,1,0,0,0,525,526,1,0,0,0,526,128,
		1,0,0,0,527,528,7,6,0,0,528,130,1,0,0,0,529,530,7,7,0,0,530,132,1,0,0,
		0,531,532,5,92,0,0,532,536,7,8,0,0,533,536,3,137,68,0,534,536,3,135,67,
		0,535,531,1,0,0,0,535,533,1,0,0,0,535,534,1,0,0,0,536,134,1,0,0,0,537,
		538,5,92,0,0,538,539,2,48,51,0,539,540,2,48,55,0,540,547,2,48,55,0,541,
		542,5,92,0,0,542,543,2,48,55,0,543,547,2,48,55,0,544,545,5,92,0,0,545,
		547,2,48,55,0,546,537,1,0,0,0,546,541,1,0,0,0,546,544,1,0,0,0,547,136,
		1,0,0,0,548,549,5,92,0,0,549,550,5,117,0,0,550,551,3,131,65,0,551,552,
		3,131,65,0,552,553,3,131,65,0,553,554,3,131,65,0,554,138,1,0,0,0,555,561,
		7,9,0,0,556,560,7,10,0,0,557,558,7,11,0,0,558,560,7,12,0,0,559,556,1,0,
		0,0,559,557,1,0,0,0,560,563,1,0,0,0,561,559,1,0,0,0,561,562,1,0,0,0,562,
		140,1,0,0,0,563,561,1,0,0,0,564,570,7,13,0,0,565,569,7,14,0,0,566,567,
		7,11,0,0,567,569,7,15,0,0,568,565,1,0,0,0,568,566,1,0,0,0,569,572,1,0,
		0,0,570,568,1,0,0,0,570,571,1,0,0,0,571,142,1,0,0,0,572,570,1,0,0,0,573,
		574,5,35,0,0,574,575,3,139,69,0,575,144,1,0,0,0,576,577,5,46,0,0,577,578,
		3,141,70,0,578,146,1,0,0,0,579,580,5,36,0,0,580,581,3,141,70,0,581,148,
		1,0,0,0,582,583,5,36,0,0,583,584,5,36,0,0,584,585,1,0,0,0,585,586,3,141,
		70,0,586,150,1,0,0,0,587,588,5,58,0,0,588,589,3,141,70,0,589,152,1,0,0,
		0,590,591,5,37,0,0,591,592,3,141,70,0,592,154,1,0,0,0,593,594,3,141,70,
		0,594,156,1,0,0,0,26,0,159,169,175,181,187,191,202,208,471,476,480,485,
		487,494,496,500,514,519,525,535,546,559,561,568,570,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace SassyPatchGrammar
