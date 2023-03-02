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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CrimsonParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface ICrimsonListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScope([NotNull] CrimsonParser.ScopeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScope([NotNull] CrimsonParser.ScopeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportUnit([NotNull] CrimsonParser.ImportUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportUnit([NotNull] CrimsonParser.ImportUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.operationHandler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperationHandler([NotNull] CrimsonParser.OperationHandlerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.operationHandler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperationHandler([NotNull] CrimsonParser.OperationHandlerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarationStatement([NotNull] CrimsonParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarationStatement([NotNull] CrimsonParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] CrimsonParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] CrimsonParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignVariableStatement([NotNull] CrimsonParser.AssignVariableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignVariableStatement([NotNull] CrimsonParser.AssignVariableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallStatement([NotNull] CrimsonParser.FunctionCallStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallStatement([NotNull] CrimsonParser.FunctionCallStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] CrimsonParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] CrimsonParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] CrimsonParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] CrimsonParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicCallStatement([NotNull] CrimsonParser.BasicCallStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicCallStatement([NotNull] CrimsonParser.BasicCallStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssemblyCallStatement([NotNull] CrimsonParser.AssemblyCallStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssemblyCallStatement([NotNull] CrimsonParser.AssemblyCallStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GlobalVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalVariableStatement([NotNull] CrimsonParser.GlobalVariableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GlobalVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalVariableStatement([NotNull] CrimsonParser.GlobalVariableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclarationStatement([NotNull] CrimsonParser.FunctionDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclarationStatement([NotNull] CrimsonParser.FunctionDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>StructureDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructureDeclarationStatement([NotNull] CrimsonParser.StructureDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StructureDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructureDeclarationStatement([NotNull] CrimsonParser.StructureDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignVariableDirect</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignVariableDirect([NotNull] CrimsonParser.AssignVariableDirectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignVariableDirect</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignVariableDirect([NotNull] CrimsonParser.AssignVariableDirectContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignVariableAtPointer</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignVariableAtPointer([NotNull] CrimsonParser.AssignVariableAtPointerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignVariableAtPointer</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignVariableAtPointer([NotNull] CrimsonParser.AssignVariableAtPointerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] CrimsonParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] CrimsonParser.IfBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] CrimsonParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] CrimsonParser.WhileBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] CrimsonParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] CrimsonParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] CrimsonParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] CrimsonParser.ElseIfBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseBlock([NotNull] CrimsonParser.ElseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseBlock([NotNull] CrimsonParser.ElseBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.basicCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicCall([NotNull] CrimsonParser.BasicCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.basicCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicCall([NotNull] CrimsonParser.BasicCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.scopedVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScopedVariableDeclaration([NotNull] CrimsonParser.ScopedVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.scopedVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScopedVariableDeclaration([NotNull] CrimsonParser.ScopedVariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionHeader([NotNull] CrimsonParser.FunctionHeaderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionHeader([NotNull] CrimsonParser.FunctionHeaderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] CrimsonParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] CrimsonParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] CrimsonParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleValue([NotNull] CrimsonParser.SimpleValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleValue([NotNull] CrimsonParser.SimpleValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.complexValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComplexValue([NotNull] CrimsonParser.ComplexValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.complexValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComplexValue([NotNull] CrimsonParser.ComplexValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.rawValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRawValue([NotNull] CrimsonParser.RawValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.rawValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRawValue([NotNull] CrimsonParser.RawValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation([NotNull] CrimsonParser.OperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation([NotNull] CrimsonParser.OperationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] CrimsonParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] CrimsonParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] CrimsonParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] CrimsonParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructureBody([NotNull] CrimsonParser.StructureBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructureBody([NotNull] CrimsonParser.StructureBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] CrimsonParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] CrimsonParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray([NotNull] CrimsonParser.ArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray([NotNull] CrimsonParser.ArrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.fullName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFullName([NotNull] CrimsonParser.FullNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.fullName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFullName([NotNull] CrimsonParser.FullNameContext context);
}
} // namespace Crimson.AntlrBuild
