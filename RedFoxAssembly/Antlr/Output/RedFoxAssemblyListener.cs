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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="RedFoxAssemblyParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface IRedFoxAssemblyListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] RedFoxAssemblyParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] RedFoxAssemblyParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WidthConfiguration</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWidthConfiguration([NotNull] RedFoxAssemblyParser.WidthConfigurationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WidthConfiguration</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWidthConfiguration([NotNull] RedFoxAssemblyParser.WidthConfigurationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ValueConfiguration</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueConfiguration([NotNull] RedFoxAssemblyParser.ValueConfigurationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ValueConfiguration</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueConfiguration([NotNull] RedFoxAssemblyParser.ValueConfigurationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.width"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWidth([NotNull] RedFoxAssemblyParser.WidthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.width"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWidth([NotNull] RedFoxAssemblyParser.WidthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] RedFoxAssemblyParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] RedFoxAssemblyParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LabelCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelCommand([NotNull] RedFoxAssemblyParser.LabelCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LabelCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelCommand([NotNull] RedFoxAssemblyParser.LabelCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>InstructionCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstructionCommand([NotNull] RedFoxAssemblyParser.InstructionCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstructionCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstructionCommand([NotNull] RedFoxAssemblyParser.InstructionCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RepeatCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeatCommand([NotNull] RedFoxAssemblyParser.RepeatCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RepeatCommand</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeatCommand([NotNull] RedFoxAssemblyParser.RepeatCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] RedFoxAssemblyParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] RedFoxAssemblyParser.LabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeat([NotNull] RedFoxAssemblyParser.RepeatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeat([NotNull] RedFoxAssemblyParser.RepeatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>HLTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHLTInstruction([NotNull] RedFoxAssemblyParser.HLTInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>HLTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHLTInstruction([NotNull] RedFoxAssemblyParser.HLTInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NOPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNOPInstruction([NotNull] RedFoxAssemblyParser.NOPInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NOPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNOPInstruction([NotNull] RedFoxAssemblyParser.NOPInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ADDInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterADDInstruction([NotNull] RedFoxAssemblyParser.ADDInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ADDInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitADDInstruction([NotNull] RedFoxAssemblyParser.ADDInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SUBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSUBInstruction([NotNull] RedFoxAssemblyParser.SUBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SUBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSUBInstruction([NotNull] RedFoxAssemblyParser.SUBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LSLInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLSLInstruction([NotNull] RedFoxAssemblyParser.LSLInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LSLInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLSLInstruction([NotNull] RedFoxAssemblyParser.LSLInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LSRInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLSRInstruction([NotNull] RedFoxAssemblyParser.LSRInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LSRInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLSRInstruction([NotNull] RedFoxAssemblyParser.LSRInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NEGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNEGInstruction([NotNull] RedFoxAssemblyParser.NEGInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NEGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNEGInstruction([NotNull] RedFoxAssemblyParser.NEGInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NOTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNOTInstruction([NotNull] RedFoxAssemblyParser.NOTInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NOTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNOTInstruction([NotNull] RedFoxAssemblyParser.NOTInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CMPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCMPInstruction([NotNull] RedFoxAssemblyParser.CMPInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CMPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCMPInstruction([NotNull] RedFoxAssemblyParser.CMPInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>JMPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJMPInstruction([NotNull] RedFoxAssemblyParser.JMPInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JMPInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJMPInstruction([NotNull] RedFoxAssemblyParser.JMPInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BFGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBFGInstruction([NotNull] RedFoxAssemblyParser.BFGInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BFGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBFGInstruction([NotNull] RedFoxAssemblyParser.BFGInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BSRInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBSRInstruction([NotNull] RedFoxAssemblyParser.BSRInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BSRInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBSRInstruction([NotNull] RedFoxAssemblyParser.BSRInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RTNInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRTNInstruction([NotNull] RedFoxAssemblyParser.RTNInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RTNInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRTNInstruction([NotNull] RedFoxAssemblyParser.RTNInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RRBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRRBInstruction([NotNull] RedFoxAssemblyParser.RRBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RRBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRRBInstruction([NotNull] RedFoxAssemblyParser.RRBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RRWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRRWInstruction([NotNull] RedFoxAssemblyParser.RRWInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RRWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRRWInstruction([NotNull] RedFoxAssemblyParser.RRWInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RMBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRMBInstruction([NotNull] RedFoxAssemblyParser.RMBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RMBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRMBInstruction([NotNull] RedFoxAssemblyParser.RMBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RMWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRMWInstruction([NotNull] RedFoxAssemblyParser.RMWInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RMWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRMWInstruction([NotNull] RedFoxAssemblyParser.RMWInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WRBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWRBInstruction([NotNull] RedFoxAssemblyParser.WRBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WRBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWRBInstruction([NotNull] RedFoxAssemblyParser.WRBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WRWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWRWInstruction([NotNull] RedFoxAssemblyParser.WRWInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WRWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWRWInstruction([NotNull] RedFoxAssemblyParser.WRWInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WMBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWMBInstruction([NotNull] RedFoxAssemblyParser.WMBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WMBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWMBInstruction([NotNull] RedFoxAssemblyParser.WMBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WMWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWMWInstruction([NotNull] RedFoxAssemblyParser.WMWInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WMWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWMWInstruction([NotNull] RedFoxAssemblyParser.WMWInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RVBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRVBInstruction([NotNull] RedFoxAssemblyParser.RVBInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RVBInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRVBInstruction([NotNull] RedFoxAssemblyParser.RVBInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RVWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRVWInstruction([NotNull] RedFoxAssemblyParser.RVWInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RVWInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRVWInstruction([NotNull] RedFoxAssemblyParser.RVWInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SINInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSINInstruction([NotNull] RedFoxAssemblyParser.SINInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SINInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSINInstruction([NotNull] RedFoxAssemblyParser.SINInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>INTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterINTInstruction([NotNull] RedFoxAssemblyParser.INTInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>INTInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitINTInstruction([NotNull] RedFoxAssemblyParser.INTInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SFGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSFGInstruction([NotNull] RedFoxAssemblyParser.SFGInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SFGInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSFGInstruction([NotNull] RedFoxAssemblyParser.SFGInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ANDInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterANDInstruction([NotNull] RedFoxAssemblyParser.ANDInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ANDInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitANDInstruction([NotNull] RedFoxAssemblyParser.ANDInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LORInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLORInstruction([NotNull] RedFoxAssemblyParser.LORInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LORInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLORInstruction([NotNull] RedFoxAssemblyParser.LORInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>XORInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXORInstruction([NotNull] RedFoxAssemblyParser.XORInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>XORInstruction</c>
	/// labeled alternative in <see cref="RedFoxAssemblyParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXORInstruction([NotNull] RedFoxAssemblyParser.XORInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.hlt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHlt([NotNull] RedFoxAssemblyParser.HltContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.hlt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHlt([NotNull] RedFoxAssemblyParser.HltContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.nop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNop([NotNull] RedFoxAssemblyParser.NopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.nop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNop([NotNull] RedFoxAssemblyParser.NopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] RedFoxAssemblyParser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] RedFoxAssemblyParser.AddContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.sub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSub([NotNull] RedFoxAssemblyParser.SubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.sub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSub([NotNull] RedFoxAssemblyParser.SubContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.lsl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLsl([NotNull] RedFoxAssemblyParser.LslContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.lsl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLsl([NotNull] RedFoxAssemblyParser.LslContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.lsr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLsr([NotNull] RedFoxAssemblyParser.LsrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.lsr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLsr([NotNull] RedFoxAssemblyParser.LsrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.neg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNeg([NotNull] RedFoxAssemblyParser.NegContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.neg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNeg([NotNull] RedFoxAssemblyParser.NegContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNot([NotNull] RedFoxAssemblyParser.NotContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNot([NotNull] RedFoxAssemblyParser.NotContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.cmp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCmp([NotNull] RedFoxAssemblyParser.CmpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.cmp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCmp([NotNull] RedFoxAssemblyParser.CmpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.jmp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJmp([NotNull] RedFoxAssemblyParser.JmpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.jmp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJmp([NotNull] RedFoxAssemblyParser.JmpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.bfg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBfg([NotNull] RedFoxAssemblyParser.BfgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.bfg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBfg([NotNull] RedFoxAssemblyParser.BfgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.bsr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBsr([NotNull] RedFoxAssemblyParser.BsrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.bsr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBsr([NotNull] RedFoxAssemblyParser.BsrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rtn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRtn([NotNull] RedFoxAssemblyParser.RtnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rtn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRtn([NotNull] RedFoxAssemblyParser.RtnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rrb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRrb([NotNull] RedFoxAssemblyParser.RrbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rrb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRrb([NotNull] RedFoxAssemblyParser.RrbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rrw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRrw([NotNull] RedFoxAssemblyParser.RrwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rrw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRrw([NotNull] RedFoxAssemblyParser.RrwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rmb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRmb([NotNull] RedFoxAssemblyParser.RmbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rmb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRmb([NotNull] RedFoxAssemblyParser.RmbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rmw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRmw([NotNull] RedFoxAssemblyParser.RmwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rmw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRmw([NotNull] RedFoxAssemblyParser.RmwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.wrb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrb([NotNull] RedFoxAssemblyParser.WrbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.wrb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrb([NotNull] RedFoxAssemblyParser.WrbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.wrw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrw([NotNull] RedFoxAssemblyParser.WrwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.wrw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrw([NotNull] RedFoxAssemblyParser.WrwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.wmb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWmb([NotNull] RedFoxAssemblyParser.WmbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.wmb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWmb([NotNull] RedFoxAssemblyParser.WmbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.wmw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWmw([NotNull] RedFoxAssemblyParser.WmwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.wmw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWmw([NotNull] RedFoxAssemblyParser.WmwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rvb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRvb([NotNull] RedFoxAssemblyParser.RvbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rvb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRvb([NotNull] RedFoxAssemblyParser.RvbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.rvw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRvw([NotNull] RedFoxAssemblyParser.RvwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.rvw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRvw([NotNull] RedFoxAssemblyParser.RvwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.sin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSin([NotNull] RedFoxAssemblyParser.SinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.sin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSin([NotNull] RedFoxAssemblyParser.SinContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] RedFoxAssemblyParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] RedFoxAssemblyParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.sfg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSfg([NotNull] RedFoxAssemblyParser.SfgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.sfg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSfg([NotNull] RedFoxAssemblyParser.SfgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] RedFoxAssemblyParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] RedFoxAssemblyParser.AndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.lor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLor([NotNull] RedFoxAssemblyParser.LorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.lor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLor([NotNull] RedFoxAssemblyParser.LorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.xor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXor([NotNull] RedFoxAssemblyParser.XorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.xor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXor([NotNull] RedFoxAssemblyParser.XorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnd([NotNull] RedFoxAssemblyParser.EndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnd([NotNull] RedFoxAssemblyParser.EndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.word"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWord([NotNull] RedFoxAssemblyParser.WordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.word"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWord([NotNull] RedFoxAssemblyParser.WordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterByte([NotNull] RedFoxAssemblyParser.ByteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitByte([NotNull] RedFoxAssemblyParser.ByteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RedFoxAssemblyParser.bytedata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBytedata([NotNull] RedFoxAssemblyParser.BytedataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RedFoxAssemblyParser.bytedata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBytedata([NotNull] RedFoxAssemblyParser.BytedataContext context);
}
} // namespace RedFoxAssembly.AntlrBuild
