//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Input/RedFoxAssembly.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace RedFoxAssembly.AntlrBuild {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class RedFoxAssemblyLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LabelStart=1, Width=2, Repeat=3, Literal=4, WordValue=5, ByteValue=6, 
		End=7, HLT=8, NOP=9, ADD=10, SUB=11, LSL=12, LSR=13, NEG=14, NOT=15, CMP=16, 
		JMP=17, BFG=18, BSR=19, RTN=20, RRB=21, RRW=22, RMB=23, RMW=24, WRB=25, 
		WRW=26, WMB=27, WMW=28, RVB=29, RVW=30, SIN=31, INT=32, SFG=33, AND=34, 
		LOR=35, XOR=36, RegisterPrefix=37, HexPrefix=38, Underscore=39, Quote=40, 
		Blank=41, Space=42, Tab=43, Digit=44, ByteLetter=45, Identifier=46, SkipTokens=47, 
		LineComment=48, EOL=49;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LabelStart", "Width", "Repeat", "Literal", "WordValue", "ByteValue", 
		"End", "HLT", "NOP", "ADD", "SUB", "LSL", "LSR", "NEG", "NOT", "CMP", 
		"JMP", "BFG", "BSR", "RTN", "RRB", "RRW", "RMB", "RMW", "WRB", "WRW", 
		"WMB", "WMW", "RVB", "RVW", "SIN", "INT", "SFG", "AND", "LOR", "XOR", 
		"RegisterPrefix", "Register", "GeneralRegister", "ComponentRegister", 
		"SpecialisedRegister", "HexPrefix", "Underscore", "Quote", "Blank", "Space", 
		"Tab", "Digit", "ByteLetter", "Identifier", "SkipTokens", "LineComment", 
		"EOL", "Alphabetic", "WhiteSpace"
	};


	public RedFoxAssemblyLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RedFoxAssemblyLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'::'", "'.width'", "'.repeat'", "'$'", "'.word'", "'.byte'", "'.end'", 
		"'HLT'", "'NOP'", "'ADD'", "'SUB'", "'LSL'", "'LSR'", "'NEG'", "'NOT'", 
		"'CMP'", "'JMP'", "'BFG'", "'BSR'", "'RTN'", "'RRB'", "'RRW'", "'RMB'", 
		"'RMW'", "'WRB'", "'WRW'", "'WMB'", "'WMW'", "'RVB'", "'RVW'", "'SIN'", 
		"'INT'", "'SFG'", "'AND'", "'LOR'", "'XOR'", null, "'0x'", "'_'", "'''", 
		null, "' '", "'\\t'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LabelStart", "Width", "Repeat", "Literal", "WordValue", "ByteValue", 
		"End", "HLT", "NOP", "ADD", "SUB", "LSL", "LSR", "NEG", "NOT", "CMP", 
		"JMP", "BFG", "BSR", "RTN", "RRB", "RRW", "RMB", "RMW", "WRB", "WRW", 
		"WMB", "WMW", "RVB", "RVW", "SIN", "INT", "SFG", "AND", "LOR", "XOR", 
		"RegisterPrefix", "HexPrefix", "Underscore", "Quote", "Blank", "Space", 
		"Tab", "Digit", "ByteLetter", "Identifier", "SkipTokens", "LineComment", 
		"EOL"
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

	public override string GrammarFileName { get { return "RedFoxAssembly.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static RedFoxAssemblyLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,49,339,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,1,0,1,0,1,0,1,1,
		1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,
		4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,
		1,7,1,7,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,11,1,11,
		1,11,1,11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,
		1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,18,1,18,
		1,18,1,18,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,21,1,21,1,21,1,21,
		1,22,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,25,1,25,
		1,25,1,25,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,28,1,28,1,28,1,28,
		1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,32,1,32,
		1,32,1,32,1,33,1,33,1,33,1,33,1,34,1,34,1,34,1,34,1,35,1,35,1,35,1,35,
		1,36,1,36,1,36,1,36,3,36,269,8,36,1,37,1,37,1,37,1,38,1,38,1,38,1,39,1,
		39,1,39,1,40,1,40,1,40,1,41,1,41,1,41,1,42,1,42,1,43,1,43,1,44,1,44,3,
		44,292,8,44,1,45,1,45,1,46,1,46,1,47,1,47,1,48,1,48,1,49,1,49,1,49,1,49,
		4,49,306,8,49,11,49,12,49,307,1,49,1,49,1,50,1,50,1,50,1,50,1,51,1,51,
		1,51,1,51,5,51,320,8,51,10,51,12,51,323,9,51,1,52,4,52,326,8,52,11,52,
		12,52,327,1,52,3,52,331,8,52,1,53,1,53,1,54,4,54,336,8,54,11,54,12,54,
		337,0,0,55,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,
		13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,
		25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,
		37,75,0,77,0,79,0,81,0,83,38,85,39,87,40,89,41,91,42,93,43,95,44,97,45,
		99,46,101,47,103,48,105,49,107,0,109,0,1,0,5,1,0,48,57,2,0,65,70,97,102,
		2,0,10,10,13,13,2,0,65,90,97,122,2,0,9,9,32,32,343,0,1,1,0,0,0,0,3,1,0,
		0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,
		1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,
		0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,
		1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,
		0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,
		1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,
		0,0,71,1,0,0,0,0,73,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,
		1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,
		0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,1,111,1,0,0,0,3,114,1,0,0,
		0,5,121,1,0,0,0,7,129,1,0,0,0,9,131,1,0,0,0,11,137,1,0,0,0,13,143,1,0,
		0,0,15,148,1,0,0,0,17,152,1,0,0,0,19,156,1,0,0,0,21,160,1,0,0,0,23,164,
		1,0,0,0,25,168,1,0,0,0,27,172,1,0,0,0,29,176,1,0,0,0,31,180,1,0,0,0,33,
		184,1,0,0,0,35,188,1,0,0,0,37,192,1,0,0,0,39,196,1,0,0,0,41,200,1,0,0,
		0,43,204,1,0,0,0,45,208,1,0,0,0,47,212,1,0,0,0,49,216,1,0,0,0,51,220,1,
		0,0,0,53,224,1,0,0,0,55,228,1,0,0,0,57,232,1,0,0,0,59,236,1,0,0,0,61,240,
		1,0,0,0,63,244,1,0,0,0,65,248,1,0,0,0,67,252,1,0,0,0,69,256,1,0,0,0,71,
		260,1,0,0,0,73,268,1,0,0,0,75,270,1,0,0,0,77,273,1,0,0,0,79,276,1,0,0,
		0,81,279,1,0,0,0,83,282,1,0,0,0,85,285,1,0,0,0,87,287,1,0,0,0,89,291,1,
		0,0,0,91,293,1,0,0,0,93,295,1,0,0,0,95,297,1,0,0,0,97,299,1,0,0,0,99,301,
		1,0,0,0,101,311,1,0,0,0,103,315,1,0,0,0,105,330,1,0,0,0,107,332,1,0,0,
		0,109,335,1,0,0,0,111,112,5,58,0,0,112,113,5,58,0,0,113,2,1,0,0,0,114,
		115,5,46,0,0,115,116,5,119,0,0,116,117,5,105,0,0,117,118,5,100,0,0,118,
		119,5,116,0,0,119,120,5,104,0,0,120,4,1,0,0,0,121,122,5,46,0,0,122,123,
		5,114,0,0,123,124,5,101,0,0,124,125,5,112,0,0,125,126,5,101,0,0,126,127,
		5,97,0,0,127,128,5,116,0,0,128,6,1,0,0,0,129,130,5,36,0,0,130,8,1,0,0,
		0,131,132,5,46,0,0,132,133,5,119,0,0,133,134,5,111,0,0,134,135,5,114,0,
		0,135,136,5,100,0,0,136,10,1,0,0,0,137,138,5,46,0,0,138,139,5,98,0,0,139,
		140,5,121,0,0,140,141,5,116,0,0,141,142,5,101,0,0,142,12,1,0,0,0,143,144,
		5,46,0,0,144,145,5,101,0,0,145,146,5,110,0,0,146,147,5,100,0,0,147,14,
		1,0,0,0,148,149,5,72,0,0,149,150,5,76,0,0,150,151,5,84,0,0,151,16,1,0,
		0,0,152,153,5,78,0,0,153,154,5,79,0,0,154,155,5,80,0,0,155,18,1,0,0,0,
		156,157,5,65,0,0,157,158,5,68,0,0,158,159,5,68,0,0,159,20,1,0,0,0,160,
		161,5,83,0,0,161,162,5,85,0,0,162,163,5,66,0,0,163,22,1,0,0,0,164,165,
		5,76,0,0,165,166,5,83,0,0,166,167,5,76,0,0,167,24,1,0,0,0,168,169,5,76,
		0,0,169,170,5,83,0,0,170,171,5,82,0,0,171,26,1,0,0,0,172,173,5,78,0,0,
		173,174,5,69,0,0,174,175,5,71,0,0,175,28,1,0,0,0,176,177,5,78,0,0,177,
		178,5,79,0,0,178,179,5,84,0,0,179,30,1,0,0,0,180,181,5,67,0,0,181,182,
		5,77,0,0,182,183,5,80,0,0,183,32,1,0,0,0,184,185,5,74,0,0,185,186,5,77,
		0,0,186,187,5,80,0,0,187,34,1,0,0,0,188,189,5,66,0,0,189,190,5,70,0,0,
		190,191,5,71,0,0,191,36,1,0,0,0,192,193,5,66,0,0,193,194,5,83,0,0,194,
		195,5,82,0,0,195,38,1,0,0,0,196,197,5,82,0,0,197,198,5,84,0,0,198,199,
		5,78,0,0,199,40,1,0,0,0,200,201,5,82,0,0,201,202,5,82,0,0,202,203,5,66,
		0,0,203,42,1,0,0,0,204,205,5,82,0,0,205,206,5,82,0,0,206,207,5,87,0,0,
		207,44,1,0,0,0,208,209,5,82,0,0,209,210,5,77,0,0,210,211,5,66,0,0,211,
		46,1,0,0,0,212,213,5,82,0,0,213,214,5,77,0,0,214,215,5,87,0,0,215,48,1,
		0,0,0,216,217,5,87,0,0,217,218,5,82,0,0,218,219,5,66,0,0,219,50,1,0,0,
		0,220,221,5,87,0,0,221,222,5,82,0,0,222,223,5,87,0,0,223,52,1,0,0,0,224,
		225,5,87,0,0,225,226,5,77,0,0,226,227,5,66,0,0,227,54,1,0,0,0,228,229,
		5,87,0,0,229,230,5,77,0,0,230,231,5,87,0,0,231,56,1,0,0,0,232,233,5,82,
		0,0,233,234,5,86,0,0,234,235,5,66,0,0,235,58,1,0,0,0,236,237,5,82,0,0,
		237,238,5,86,0,0,238,239,5,87,0,0,239,60,1,0,0,0,240,241,5,83,0,0,241,
		242,5,73,0,0,242,243,5,78,0,0,243,62,1,0,0,0,244,245,5,73,0,0,245,246,
		5,78,0,0,246,247,5,84,0,0,247,64,1,0,0,0,248,249,5,83,0,0,249,250,5,70,
		0,0,250,251,5,71,0,0,251,66,1,0,0,0,252,253,5,65,0,0,253,254,5,78,0,0,
		254,255,5,68,0,0,255,68,1,0,0,0,256,257,5,76,0,0,257,258,5,79,0,0,258,
		259,5,82,0,0,259,70,1,0,0,0,260,261,5,88,0,0,261,262,5,79,0,0,262,263,
		5,82,0,0,263,72,1,0,0,0,264,269,3,75,37,0,265,269,3,77,38,0,266,269,3,
		79,39,0,267,269,3,81,40,0,268,264,1,0,0,0,268,265,1,0,0,0,268,266,1,0,
		0,0,268,267,1,0,0,0,269,74,1,0,0,0,270,271,5,82,0,0,271,272,5,120,0,0,
		272,76,1,0,0,0,273,274,5,71,0,0,274,275,5,120,0,0,275,78,1,0,0,0,276,277,
		5,67,0,0,277,278,5,120,0,0,278,80,1,0,0,0,279,280,5,83,0,0,280,281,5,120,
		0,0,281,82,1,0,0,0,282,283,5,48,0,0,283,284,5,120,0,0,284,84,1,0,0,0,285,
		286,5,95,0,0,286,86,1,0,0,0,287,288,5,39,0,0,288,88,1,0,0,0,289,292,3,
		91,45,0,290,292,3,93,46,0,291,289,1,0,0,0,291,290,1,0,0,0,292,90,1,0,0,
		0,293,294,5,32,0,0,294,92,1,0,0,0,295,296,5,9,0,0,296,94,1,0,0,0,297,298,
		7,0,0,0,298,96,1,0,0,0,299,300,7,1,0,0,300,98,1,0,0,0,301,305,3,85,42,
		0,302,306,3,107,53,0,303,306,3,95,47,0,304,306,3,85,42,0,305,302,1,0,0,
		0,305,303,1,0,0,0,305,304,1,0,0,0,306,307,1,0,0,0,307,305,1,0,0,0,307,
		308,1,0,0,0,308,309,1,0,0,0,309,310,3,85,42,0,310,100,1,0,0,0,311,312,
		3,103,51,0,312,313,1,0,0,0,313,314,6,50,0,0,314,102,1,0,0,0,315,316,5,
		47,0,0,316,317,5,47,0,0,317,321,1,0,0,0,318,320,8,2,0,0,319,318,1,0,0,
		0,320,323,1,0,0,0,321,319,1,0,0,0,321,322,1,0,0,0,322,104,1,0,0,0,323,
		321,1,0,0,0,324,326,7,2,0,0,325,324,1,0,0,0,326,327,1,0,0,0,327,325,1,
		0,0,0,327,328,1,0,0,0,328,331,1,0,0,0,329,331,5,0,0,1,330,325,1,0,0,0,
		330,329,1,0,0,0,331,106,1,0,0,0,332,333,7,3,0,0,333,108,1,0,0,0,334,336,
		7,4,0,0,335,334,1,0,0,0,336,337,1,0,0,0,337,335,1,0,0,0,337,338,1,0,0,
		0,338,110,1,0,0,0,9,0,268,291,305,307,321,327,330,337,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace RedFoxAssembly.AntlrBuild
