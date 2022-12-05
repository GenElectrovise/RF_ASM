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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICrimsonVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CrimsonBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICrimsonVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.compilationUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompilationUnit([NotNull] CrimsonParser.CompilationUnitContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitImportUnit([NotNull] CrimsonParser.ImportUnitContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>GlobalVariableUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.compilationUnitStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGlobalVariableUnitStatement([NotNull] CrimsonParser.GlobalVariableUnitStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.compilationUnitStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionUnitStatement([NotNull] CrimsonParser.FunctionUnitStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>StructureUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.compilationUnitStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStructureUnitStatement([NotNull] CrimsonParser.StructureUnitStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionStatement([NotNull] CrimsonParser.FunctionStatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.assignVariable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignVariable([NotNull] CrimsonParser.AssignVariableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfBlock([NotNull] CrimsonParser.IfBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondition([NotNull] CrimsonParser.ConditionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elifBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElifBlock([NotNull] CrimsonParser.ElifBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseBlock([NotNull] CrimsonParser.ElseBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.inputParameters"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInputParameters([NotNull] CrimsonParser.InputParametersContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.allocateMemory"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAllocateMemory([NotNull] CrimsonParser.AllocateMemoryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.resolvableValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitResolvableValue([NotNull] CrimsonParser.ResolvableValueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParameterList([NotNull] CrimsonParser.ParameterListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParameter([NotNull] CrimsonParser.ParameterContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStructureBody([NotNull] CrimsonParser.StructureBodyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitType([NotNull] CrimsonParser.TypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArray([NotNull] CrimsonParser.ArrayContext context) { return VisitChildren(context); }
}
} // namespace Crimson.AntlrBuild
