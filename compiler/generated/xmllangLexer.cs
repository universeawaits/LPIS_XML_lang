//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\User\source\repos\xmllang\xmllang.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace xmllang {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class xmllangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FOR=1, IF=2, IN=3, TAG=4, ELSE=5, ATTR=6, NAME=7, TEXT=8, NODES=9, ATTRS=10, 
		GEN=11, PRINT=12, VALUE=13, PARSE=14, ARRAY=15, SWITCH=16, CASE=17, DEFAULT=18, 
		PRIMITIVE=19, AT=20, ID=21, FILENAME=22, STRING=23, NEWLINE=24, ASSIGN=25, 
		EQ=26, NOT=27, APPEND_ATTR=28, APPEND_CHILD=29, REMOVE_ATTR=30, REMOVE_CHILD=31, 
		ROOT=32, INT=33, QT=34, COLON=35, OPEN_BRACKET=36, CLOSE_BRACKET=37, SPACE=38, 
		COMMA=39, DOT=40, OPEN_BLOCK=41, CLOSE_BLOCK=42;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"FOR", "IF", "IN", "TAG", "ELSE", "ATTR", "NAME", "TEXT", "NODES", "ATTRS", 
		"GEN", "PRINT", "VALUE", "PARSE", "ARRAY", "SWITCH", "CASE", "DEFAULT", 
		"PRIMITIVE", "AT", "ID", "FILENAME", "STRING", "NEWLINE", "ASSIGN", "EQ", 
		"NOT", "APPEND_ATTR", "APPEND_CHILD", "REMOVE_ATTR", "REMOVE_CHILD", "ROOT", 
		"INT", "QT", "COLON", "OPEN_BRACKET", "CLOSE_BRACKET", "SPACE", "COMMA", 
		"DOT", "OPEN_BLOCK", "CLOSE_BLOCK"
	};


	public xmllangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public xmllangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'for each'", "'if'", "'in'", "'node'", "'else'", "'attr'", "'name'", 
		"'text'", "'nodes'", "'attrs'", "'generate'", "'print'", "'value'", "'parse'", 
		"'array'", "'switch'", "'case'", "'default'", null, "'@'", null, null, 
		null, null, "'='", "'=='", "'!='", "'adds attr'", "'adds child'", "'removes attr'", 
		"'removes child'", "'!'", null, "'\"'", "':'", "'('", "')'", null, "','", 
		"'.'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FOR", "IF", "IN", "TAG", "ELSE", "ATTR", "NAME", "TEXT", "NODES", 
		"ATTRS", "GEN", "PRINT", "VALUE", "PARSE", "ARRAY", "SWITCH", "CASE", 
		"DEFAULT", "PRIMITIVE", "AT", "ID", "FILENAME", "STRING", "NEWLINE", "ASSIGN", 
		"EQ", "NOT", "APPEND_ATTR", "APPEND_CHILD", "REMOVE_ATTR", "REMOVE_CHILD", 
		"ROOT", "INT", "QT", "COLON", "OPEN_BRACKET", "CLOSE_BRACKET", "SPACE", 
		"COMMA", "DOT", "OPEN_BLOCK", "CLOSE_BLOCK"
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

	public override string GrammarFileName { get { return "xmllang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static xmllangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ',', '\x136', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x5', '\x14', '\xCA', 
		'\n', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x6', '\x16', 
		'\xCF', '\n', '\x16', '\r', '\x16', '\xE', '\x16', '\xD0', '\x3', '\x17', 
		'\x6', '\x17', '\xD4', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\xD5', 
		'\x3', '\x18', '\x3', '\x18', '\a', '\x18', '\xDA', '\n', '\x18', '\f', 
		'\x18', '\xE', '\x18', '\xDD', '\v', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x19', '\x5', '\x19', '\xE2', '\n', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', '!', 
		'\x3', '!', '\x3', '\"', '\x6', '\"', '\x121', '\n', '\"', '\r', '\"', 
		'\xE', '\"', '\x122', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', 
		'\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', 
		'\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', 
		'\x3', '+', '\x3', '+', '\x3', '\xDB', '\x2', ',', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', 'S', '+', 'U', ',', '\x3', '\x2', '\x6', '\x4', '\x2', '\x61', '\x61', 
		'\x63', '|', '\a', '\x2', '\x30', '\x30', '\x43', '\\', '\x63', '|', '~', 
		'~', '\x80', '\x80', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\v', '\v', 
		'\"', '\"', '\x2', '\x13B', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'W', '\x3', '\x2', '\x2', '\x2', '\x5', '`', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x63', '\x3', '\x2', '\x2', '\x2', '\t', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\v', 'k', '\x3', '\x2', '\x2', '\x2', '\r', 
		'p', '\x3', '\x2', '\x2', '\x2', '\xF', 'u', '\x3', '\x2', '\x2', '\x2', 
		'\x11', 'z', '\x3', '\x2', '\x2', '\x2', '\x13', '\x7F', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x85', '\x3', '\x2', '\x2', '\x2', '\x17', '\x8B', 
		'\x3', '\x2', '\x2', '\x2', '\x19', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x1D', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '\xA6', '\x3', '\x2', '\x2', '\x2', '!', '\xAC', 
		'\x3', '\x2', '\x2', '\x2', '#', '\xB3', '\x3', '\x2', '\x2', '\x2', '%', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\'', '\xC9', '\x3', '\x2', '\x2', 
		'\x2', ')', '\xCB', '\x3', '\x2', '\x2', '\x2', '+', '\xCE', '\x3', '\x2', 
		'\x2', '\x2', '-', '\xD3', '\x3', '\x2', '\x2', '\x2', '/', '\xD7', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\xE1', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\xE5', '\x3', '\x2', '\x2', '\x2', '\x35', '\xE7', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\xEA', '\x3', '\x2', '\x2', '\x2', '\x39', '\xED', '\x3', 
		'\x2', '\x2', '\x2', ';', '\xF7', '\x3', '\x2', '\x2', '\x2', '=', '\x102', 
		'\x3', '\x2', '\x2', '\x2', '?', '\x10F', '\x3', '\x2', '\x2', '\x2', 
		'\x41', '\x11D', '\x3', '\x2', '\x2', '\x2', '\x43', '\x120', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x124', '\x3', '\x2', '\x2', '\x2', 'G', '\x126', 
		'\x3', '\x2', '\x2', '\x2', 'I', '\x128', '\x3', '\x2', '\x2', '\x2', 
		'K', '\x12A', '\x3', '\x2', '\x2', '\x2', 'M', '\x12C', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\x12E', '\x3', '\x2', '\x2', '\x2', 'Q', '\x130', 
		'\x3', '\x2', '\x2', '\x2', 'S', '\x132', '\x3', '\x2', '\x2', '\x2', 
		'U', '\x134', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 'h', '\x2', 
		'\x2', 'X', 'Y', '\a', 'q', '\x2', '\x2', 'Y', 'Z', '\a', 't', '\x2', 
		'\x2', 'Z', '[', '\a', '\"', '\x2', '\x2', '[', '\\', '\a', 'g', '\x2', 
		'\x2', '\\', ']', '\a', '\x63', '\x2', '\x2', ']', '^', '\a', '\x65', 
		'\x2', '\x2', '^', '_', '\a', 'j', '\x2', '\x2', '_', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x61', '\a', 'k', '\x2', '\x2', '\x61', '\x62', '\a', 
		'h', '\x2', '\x2', '\x62', '\x6', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x64', '\a', 'k', '\x2', '\x2', '\x64', '\x65', '\a', 'p', '\x2', '\x2', 
		'\x65', '\b', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', 'p', '\x2', 
		'\x2', 'g', 'h', '\a', 'q', '\x2', '\x2', 'h', 'i', '\a', '\x66', '\x2', 
		'\x2', 'i', 'j', '\a', 'g', '\x2', '\x2', 'j', '\n', '\x3', '\x2', '\x2', 
		'\x2', 'k', 'l', '\a', 'g', '\x2', '\x2', 'l', 'm', '\a', 'n', '\x2', 
		'\x2', 'm', 'n', '\a', 'u', '\x2', '\x2', 'n', 'o', '\a', 'g', '\x2', 
		'\x2', 'o', '\f', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', '\x63', 
		'\x2', '\x2', 'q', 'r', '\a', 'v', '\x2', '\x2', 'r', 's', '\a', 'v', 
		'\x2', '\x2', 's', 't', '\a', 't', '\x2', '\x2', 't', '\xE', '\x3', '\x2', 
		'\x2', '\x2', 'u', 'v', '\a', 'p', '\x2', '\x2', 'v', 'w', '\a', '\x63', 
		'\x2', '\x2', 'w', 'x', '\a', 'o', '\x2', '\x2', 'x', 'y', '\a', 'g', 
		'\x2', '\x2', 'y', '\x10', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', 
		'v', '\x2', '\x2', '{', '|', '\a', 'g', '\x2', '\x2', '|', '}', '\a', 
		'z', '\x2', '\x2', '}', '~', '\a', 'v', '\x2', '\x2', '~', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '\x7F', '\x80', '\a', 'p', '\x2', '\x2', '\x80', 
		'\x81', '\a', 'q', '\x2', '\x2', '\x81', '\x82', '\a', '\x66', '\x2', 
		'\x2', '\x82', '\x83', '\a', 'g', '\x2', '\x2', '\x83', '\x84', '\a', 
		'u', '\x2', '\x2', '\x84', '\x14', '\x3', '\x2', '\x2', '\x2', '\x85', 
		'\x86', '\a', '\x63', '\x2', '\x2', '\x86', '\x87', '\a', 'v', '\x2', 
		'\x2', '\x87', '\x88', '\a', 'v', '\x2', '\x2', '\x88', '\x89', '\a', 
		't', '\x2', '\x2', '\x89', '\x8A', '\a', 'u', '\x2', '\x2', '\x8A', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\a', 'i', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', 'g', '\x2', '\x2', '\x8D', '\x8E', '\a', 'p', '\x2', '\x2', 
		'\x8E', '\x8F', '\a', 'g', '\x2', '\x2', '\x8F', '\x90', '\a', 't', '\x2', 
		'\x2', '\x90', '\x91', '\a', '\x63', '\x2', '\x2', '\x91', '\x92', '\a', 
		'v', '\x2', '\x2', '\x92', '\x93', '\a', 'g', '\x2', '\x2', '\x93', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'r', '\x2', '\x2', '\x95', 
		'\x96', '\a', 't', '\x2', '\x2', '\x96', '\x97', '\a', 'k', '\x2', '\x2', 
		'\x97', '\x98', '\a', 'p', '\x2', '\x2', '\x98', '\x99', '\a', 'v', '\x2', 
		'\x2', '\x99', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\a', 
		'x', '\x2', '\x2', '\x9B', '\x9C', '\a', '\x63', '\x2', '\x2', '\x9C', 
		'\x9D', '\a', 'n', '\x2', '\x2', '\x9D', '\x9E', '\a', 'w', '\x2', '\x2', 
		'\x9E', '\x9F', '\a', 'g', '\x2', '\x2', '\x9F', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\xA0', '\xA1', '\a', 'r', '\x2', '\x2', '\xA1', '\xA2', 
		'\a', '\x63', '\x2', '\x2', '\xA2', '\xA3', '\a', 't', '\x2', '\x2', '\xA3', 
		'\xA4', '\a', 'u', '\x2', '\x2', '\xA4', '\xA5', '\a', 'g', '\x2', '\x2', 
		'\xA5', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', '\a', '\x63', 
		'\x2', '\x2', '\xA7', '\xA8', '\a', 't', '\x2', '\x2', '\xA8', '\xA9', 
		'\a', 't', '\x2', '\x2', '\xA9', '\xAA', '\a', '\x63', '\x2', '\x2', '\xAA', 
		'\xAB', '\a', '{', '\x2', '\x2', '\xAB', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\xAC', '\xAD', '\a', 'u', '\x2', '\x2', '\xAD', '\xAE', '\a', 'y', '\x2', 
		'\x2', '\xAE', '\xAF', '\a', 'k', '\x2', '\x2', '\xAF', '\xB0', '\a', 
		'v', '\x2', '\x2', '\xB0', '\xB1', '\a', '\x65', '\x2', '\x2', '\xB1', 
		'\xB2', '\a', 'j', '\x2', '\x2', '\xB2', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\xB3', '\xB4', '\a', '\x65', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x63', 
		'\x2', '\x2', '\xB5', '\xB6', '\a', 'u', '\x2', '\x2', '\xB6', '\xB7', 
		'\a', 'g', '\x2', '\x2', '\xB7', '$', '\x3', '\x2', '\x2', '\x2', '\xB8', 
		'\xB9', '\a', '\x66', '\x2', '\x2', '\xB9', '\xBA', '\a', 'g', '\x2', 
		'\x2', '\xBA', '\xBB', '\a', 'h', '\x2', '\x2', '\xBB', '\xBC', '\a', 
		'\x63', '\x2', '\x2', '\xBC', '\xBD', '\a', 'w', '\x2', '\x2', '\xBD', 
		'\xBE', '\a', 'n', '\x2', '\x2', '\xBE', '\xBF', '\a', 'v', '\x2', '\x2', 
		'\xBF', '&', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\a', 'k', '\x2', 
		'\x2', '\xC1', '\xC2', '\a', 'p', '\x2', '\x2', '\xC2', '\xCA', '\a', 
		'v', '\x2', '\x2', '\xC3', '\xC4', '\a', 'u', '\x2', '\x2', '\xC4', '\xC5', 
		'\a', 'v', '\x2', '\x2', '\xC5', '\xC6', '\a', 't', '\x2', '\x2', '\xC6', 
		'\xC7', '\a', 'k', '\x2', '\x2', '\xC7', '\xC8', '\a', 'p', '\x2', '\x2', 
		'\xC8', '\xCA', '\a', 'i', '\x2', '\x2', '\xC9', '\xC0', '\x3', '\x2', 
		'\x2', '\x2', '\xC9', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xCA', '(', 
		'\x3', '\x2', '\x2', '\x2', '\xCB', '\xCC', '\a', '\x42', '\x2', '\x2', 
		'\xCC', '*', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCF', '\t', '\x2', 
		'\x2', '\x2', '\xCE', '\xCD', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', 
		'\x3', '\x2', '\x2', '\x2', '\xD0', '\xCE', '\x3', '\x2', '\x2', '\x2', 
		'\xD0', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD1', ',', '\x3', '\x2', 
		'\x2', '\x2', '\xD2', '\xD4', '\t', '\x3', '\x2', '\x2', '\xD3', '\xD2', 
		'\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', '\x3', '\x2', '\x2', '\x2', 
		'\xD5', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD6', '\x3', '\x2', 
		'\x2', '\x2', '\xD6', '.', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xDB', 
		'\a', '$', '\x2', '\x2', '\xD8', '\xDA', '\v', '\x2', '\x2', '\x2', '\xD9', 
		'\xD8', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDD', '\x3', '\x2', '\x2', 
		'\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xD9', '\x3', 
		'\x2', '\x2', '\x2', '\xDC', '\xDE', '\x3', '\x2', '\x2', '\x2', '\xDD', 
		'\xDB', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', '$', '\x2', 
		'\x2', '\xDF', '\x30', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE2', '\a', 
		'\xF', '\x2', '\x2', '\xE1', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE1', 
		'\xE2', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\x3', '\x2', '\x2', 
		'\x2', '\xE3', '\xE4', '\a', '\f', '\x2', '\x2', '\xE4', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\xE5', '\xE6', '\a', '?', '\x2', '\x2', '\xE6', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE8', '\a', '?', '\x2', 
		'\x2', '\xE8', '\xE9', '\a', '?', '\x2', '\x2', '\xE9', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xEB', '\a', '#', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', '?', '\x2', '\x2', '\xEC', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\xED', '\xEE', '\a', '\x63', '\x2', '\x2', '\xEE', '\xEF', '\a', 
		'\x66', '\x2', '\x2', '\xEF', '\xF0', '\a', '\x66', '\x2', '\x2', '\xF0', 
		'\xF1', '\a', 'u', '\x2', '\x2', '\xF1', '\xF2', '\a', '\"', '\x2', '\x2', 
		'\xF2', '\xF3', '\a', '\x63', '\x2', '\x2', '\xF3', '\xF4', '\a', 'v', 
		'\x2', '\x2', '\xF4', '\xF5', '\a', 'v', '\x2', '\x2', '\xF5', '\xF6', 
		'\a', 't', '\x2', '\x2', '\xF6', ':', '\x3', '\x2', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', '\x63', '\x2', '\x2', '\xF8', '\xF9', '\a', '\x66', '\x2', 
		'\x2', '\xF9', '\xFA', '\a', '\x66', '\x2', '\x2', '\xFA', '\xFB', '\a', 
		'u', '\x2', '\x2', '\xFB', '\xFC', '\a', '\"', '\x2', '\x2', '\xFC', '\xFD', 
		'\a', '\x65', '\x2', '\x2', '\xFD', '\xFE', '\a', 'j', '\x2', '\x2', '\xFE', 
		'\xFF', '\a', 'k', '\x2', '\x2', '\xFF', '\x100', '\a', 'n', '\x2', '\x2', 
		'\x100', '\x101', '\a', '\x66', '\x2', '\x2', '\x101', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x102', '\x103', '\a', 't', '\x2', '\x2', '\x103', '\x104', 
		'\a', 'g', '\x2', '\x2', '\x104', '\x105', '\a', 'o', '\x2', '\x2', '\x105', 
		'\x106', '\a', 'q', '\x2', '\x2', '\x106', '\x107', '\a', 'x', '\x2', 
		'\x2', '\x107', '\x108', '\a', 'g', '\x2', '\x2', '\x108', '\x109', '\a', 
		'u', '\x2', '\x2', '\x109', '\x10A', '\a', '\"', '\x2', '\x2', '\x10A', 
		'\x10B', '\a', '\x63', '\x2', '\x2', '\x10B', '\x10C', '\a', 'v', '\x2', 
		'\x2', '\x10C', '\x10D', '\a', 'v', '\x2', '\x2', '\x10D', '\x10E', '\a', 
		't', '\x2', '\x2', '\x10E', '>', '\x3', '\x2', '\x2', '\x2', '\x10F', 
		'\x110', '\a', 't', '\x2', '\x2', '\x110', '\x111', '\a', 'g', '\x2', 
		'\x2', '\x111', '\x112', '\a', 'o', '\x2', '\x2', '\x112', '\x113', '\a', 
		'q', '\x2', '\x2', '\x113', '\x114', '\a', 'x', '\x2', '\x2', '\x114', 
		'\x115', '\a', 'g', '\x2', '\x2', '\x115', '\x116', '\a', 'u', '\x2', 
		'\x2', '\x116', '\x117', '\a', '\"', '\x2', '\x2', '\x117', '\x118', '\a', 
		'\x65', '\x2', '\x2', '\x118', '\x119', '\a', 'j', '\x2', '\x2', '\x119', 
		'\x11A', '\a', 'k', '\x2', '\x2', '\x11A', '\x11B', '\a', 'n', '\x2', 
		'\x2', '\x11B', '\x11C', '\a', '\x66', '\x2', '\x2', '\x11C', '@', '\x3', 
		'\x2', '\x2', '\x2', '\x11D', '\x11E', '\a', '#', '\x2', '\x2', '\x11E', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x121', '\t', '\x4', '\x2', 
		'\x2', '\x120', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x121', '\x122', 
		'\x3', '\x2', '\x2', '\x2', '\x122', '\x120', '\x3', '\x2', '\x2', '\x2', 
		'\x122', '\x123', '\x3', '\x2', '\x2', '\x2', '\x123', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\x124', '\x125', '\a', '$', '\x2', '\x2', '\x125', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\x126', '\x127', '\a', '<', '\x2', 
		'\x2', '\x127', 'H', '\x3', '\x2', '\x2', '\x2', '\x128', '\x129', '\a', 
		'*', '\x2', '\x2', '\x129', 'J', '\x3', '\x2', '\x2', '\x2', '\x12A', 
		'\x12B', '\a', '+', '\x2', '\x2', '\x12B', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\x12C', '\x12D', '\t', '\x5', '\x2', '\x2', '\x12D', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x12E', '\x12F', '\a', '.', '\x2', '\x2', '\x12F', 'P', 
		'\x3', '\x2', '\x2', '\x2', '\x130', '\x131', '\a', '\x30', '\x2', '\x2', 
		'\x131', 'R', '\x3', '\x2', '\x2', '\x2', '\x132', '\x133', '\a', '}', 
		'\x2', '\x2', '\x133', 'T', '\x3', '\x2', '\x2', '\x2', '\x134', '\x135', 
		'\a', '\x7F', '\x2', '\x2', '\x135', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x2', '\xC9', '\xD0', '\xD5', '\xDB', '\xE1', '\x122', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace xmllang
