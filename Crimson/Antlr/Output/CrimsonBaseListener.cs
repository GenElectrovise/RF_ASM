//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Input/Crimson.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Crimson.AntlrBuild {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICrimsonListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CrimsonBaseListener : ICrimsonListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.translationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTranslationUnit([NotNull] CrimsonParser.TranslationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.translationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTranslationUnit([NotNull] CrimsonParser.TranslationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportUnit([NotNull] CrimsonParser.ImportUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportUnit([NotNull] CrimsonParser.ImportUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.operationHandler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperationHandler([NotNull] CrimsonParser.OperationHandlerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.operationHandler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperationHandler([NotNull] CrimsonParser.OperationHandlerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GlobalVariableUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalVariableUnitStatement([NotNull] CrimsonParser.GlobalVariableUnitStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GlobalVariableUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalVariableUnitStatement([NotNull] CrimsonParser.GlobalVariableUnitStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionUnitStatement([NotNull] CrimsonParser.FunctionUnitStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionUnitStatement([NotNull] CrimsonParser.FunctionUnitStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>StructureUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructureUnitStatement([NotNull] CrimsonParser.StructureUnitStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StructureUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructureUnitStatement([NotNull] CrimsonParser.StructureUnitStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionHeader([NotNull] CrimsonParser.FunctionHeaderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionHeader([NotNull] CrimsonParser.FunctionHeaderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionVariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionVariableDeclarationStatement([NotNull] CrimsonParser.FunctionVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionVariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionVariableDeclarationStatement([NotNull] CrimsonParser.FunctionVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionReturnStatement([NotNull] CrimsonParser.FunctionReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionReturnStatement([NotNull] CrimsonParser.FunctionReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionAssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionAssignVariableStatement([NotNull] CrimsonParser.FunctionAssignVariableStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionAssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionAssignVariableStatement([NotNull] CrimsonParser.FunctionAssignVariableStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionFunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionFunctionCallStatement([NotNull] CrimsonParser.FunctionFunctionCallStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionFunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionFunctionCallStatement([NotNull] CrimsonParser.FunctionFunctionCallStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionIfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionIfStatement([NotNull] CrimsonParser.FunctionIfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionIfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionIfStatement([NotNull] CrimsonParser.FunctionIfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionWhileStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionWhileStatement([NotNull] CrimsonParser.FunctionWhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionWhileStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionWhileStatement([NotNull] CrimsonParser.FunctionWhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionAssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionAssemblyCallStatement([NotNull] CrimsonParser.FunctionAssemblyCallStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionAssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionAssemblyCallStatement([NotNull] CrimsonParser.FunctionAssemblyCallStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignVariableDirect</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignVariableDirect([NotNull] CrimsonParser.AssignVariableDirectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignVariableDirect</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignVariableDirect([NotNull] CrimsonParser.AssignVariableDirectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignVariableAtPointer</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignVariableAtPointer([NotNull] CrimsonParser.AssignVariableAtPointerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignVariableAtPointer</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignVariableAtPointer([NotNull] CrimsonParser.AssignVariableAtPointerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBlock([NotNull] CrimsonParser.IfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBlock([NotNull] CrimsonParser.IfBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileBlock([NotNull] CrimsonParser.WhileBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileBlock([NotNull] CrimsonParser.WhileBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] CrimsonParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] CrimsonParser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfBlock([NotNull] CrimsonParser.ElseIfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfBlock([NotNull] CrimsonParser.ElseIfBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseBlock([NotNull] CrimsonParser.ElseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseBlock([NotNull] CrimsonParser.ElseBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] CrimsonParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArguments([NotNull] CrimsonParser.ArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArguments([NotNull] CrimsonParser.ArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.simpleValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleValue([NotNull] CrimsonParser.SimpleValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.simpleValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleValue([NotNull] CrimsonParser.SimpleValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.complexValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComplexValue([NotNull] CrimsonParser.ComplexValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.complexValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComplexValue([NotNull] CrimsonParser.ComplexValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.rawValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRawValue([NotNull] CrimsonParser.RawValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.rawValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRawValue([NotNull] CrimsonParser.RawValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperation([NotNull] CrimsonParser.OperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperation([NotNull] CrimsonParser.OperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] CrimsonParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] CrimsonParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] CrimsonParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] CrimsonParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructureBody([NotNull] CrimsonParser.StructureBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructureBody([NotNull] CrimsonParser.StructureBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] CrimsonParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] CrimsonParser.TypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray([NotNull] CrimsonParser.ArrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray([NotNull] CrimsonParser.ArrayContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.fullName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFullName([NotNull] CrimsonParser.FullNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.fullName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFullName([NotNull] CrimsonParser.FullNameContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Crimson.AntlrBuild
