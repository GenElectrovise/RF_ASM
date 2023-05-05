﻿using Antlr4.Runtime.Misc;
using Compiler.AntlrBuild;
using NLog;
using System.Text.RegularExpressions;
using Compiler.Parsing.Statements;
using Compiler.Parsing.Tokens;
using Compiler.Parsing.Tokens.Values;
using Compiler.Common.Exceptions;

namespace Compiler.Parsing
{
    internal class ScopeVisitor : CrimsonBaseVisitor<object>
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        // ==================== VISITOR ====================

        public static readonly Stack<Scope> scopeStack = new Stack<Scope>();

        private static readonly Regex URI_SCHEME_FIXER = new Regex(@"");

        public override Scope VisitScope ([NotNull] CrimsonParser.ScopeContext context)
        {
            try
            {
                Scope scope = new Scope(null!, scopeStack.TryPeek(out Scope? result) ? result : null);
                scopeStack.Push(scope);

                // Visit imports
                IList<CrimsonParser.ImportUnitContext> importCtxs = context._imports;
                foreach (CrimsonParser.ImportUnitContext importCtx in importCtxs)
                {
                    FullNameCToken id = VisitFullName(importCtx.fullName());
                    ImportCStatement import = new ImportCStatement(importCtx.uri.Text, id);
                    scope.Imports.Add(id.ToString(), import);
                }

                // Add operation handlers
                IList<CrimsonParser.OperationHandlerContext> operationHandlersCtxs = context._opHandlers;
                //foreach (CrimsonParser.OperationHandlerContext unitStatementCtx in operationHandlersCtxs) //TODO Operation handlers ScopeVisitor
                //    OperationHandlerCStatement unitStatement = VisitOperationHandler(unitStatementCtx);

                // Visit Compilation-Unit statements
                IList<CrimsonParser.StatementContext> unitStatementCtxs = context._statements;
                foreach (CrimsonParser.StatementContext unitStatementCtx in unitStatementCtxs)
                {
                    AbstractCrimsonStatement unitStatement = ParseStatement(unitStatementCtx);
                    scope.AddStatement(unitStatement);
                }

                // Populate output fields

                return scopeStack.Pop();
            }
            catch (Exception ex)
            {
                Program.Panic($"{GetType()} was unable to parse the given {(context == null ? "NULL" : context.GetType())}", Program.PanicCode.COMPILE_PARSE_SCOPE, ex);
                throw;
            }
        }

        private AbstractCrimsonStatement ParseStatement (CrimsonParser.StatementContext stCtx)
        {

            if (stCtx is CrimsonParser.GlobalVariableStatementContext globalContext)
            {
                CrimsonParser.GlobalVariableDeclarationContext declaration = globalContext.globalVariableDeclaration();
                return VisitGlobalVariableDeclaration(declaration);
            }
            else if (stCtx is CrimsonParser.ScopeVariableStatementContext scopeVarContext)
            {
                CrimsonParser.ScopeVariableDeclarationContext declaration = scopeVarContext.scopeVariableDeclaration();
                return VisitScopeVariableDeclaration(declaration);
            }
            else if (stCtx is CrimsonParser.FunctionDeclarationStatementContext functionContext)
            {
                CrimsonParser.FunctionDeclarationContext declaration = functionContext.functionDeclaration();
                return VisitFunctionDeclaration(declaration);
            }
            else if (stCtx is CrimsonParser.StructureDeclarationStatementContext structureContext)
            {
                CrimsonParser.StructureDeclarationContext declaration = structureContext.structureDeclaration();
                return VisitStructureDeclaration(declaration);
            }
            else if (stCtx is CrimsonParser.ReturnStatementContext returnContext)
            {
                CrimsonParser.FunctionReturnContext rtnCtx = returnContext.functionReturn();
                return VisitFunctionReturn(rtnCtx);
            }
            else if (stCtx is CrimsonParser.AssignVariableStatementContext assignContext)
            {
                CrimsonParser.AssignVariableContext asvCtx = assignContext.assignVariable();
                return ParseAssignVariable(asvCtx);
            }
            else if (stCtx is CrimsonParser.FunctionCallStatementContext callContext)
            {
                CrimsonParser.FunctionCallContext fncCtx = callContext.functionCall();
                return VisitFunctionCall(fncCtx);
            }
            else if (stCtx is CrimsonParser.IfStatementContext ifContext)
            {
                CrimsonParser.IfBlockContext ifCtx = ifContext.ifBlock();
                return VisitIfBlock(ifCtx);
            }
            else if (stCtx is CrimsonParser.WhileStatementContext whileContext)
            {
                CrimsonParser.WhileBlockContext whileCtx = whileContext.whileBlock();
                return VisitWhileBlock(whileCtx);
            }
            else if (stCtx is CrimsonParser.BasicCallStatementContext basicContext)
            {
                CrimsonParser.BasicCallContext bcCtx = basicContext.basicCall();
                return VisitBasicCall(bcCtx);
            }
            else if (stCtx is CrimsonParser.AssemblyCallStatementContext assContext)
            {
                CrimsonParser.AssemblyCallContext acCtx = assContext.assemblyCall();
                return VisitAssemblyCall(acCtx);
            }
            else
                throw new StatementParseException("The given CrimsonParser.FunctionStatementContext " + stCtx + " is not of a permissable type", null, null);
        }

        // ----------------------------------------------------
        // --------------------------------- SCOPE HEADERS
        // ----------------------------------------------------

        public override OperationHandlerCStatement VisitOperationHandler ([NotNull] CrimsonParser.OperationHandlerContext context)
        {
            OperationResolvableValueCToken.OperationType opType = OperationResolvableValueCToken.ParseOpType(context.op.Text);
            FullNameCToken id = VisitFullName(context.identifier);
            OperationHandlerCStatement ohsc = new OperationHandlerCStatement(opType, id);

            return ohsc;
        }

        public override GlobalVariableCStatement VisitGlobalVariableDeclaration ([NotNull] CrimsonParser.GlobalVariableDeclarationContext context)
        {
            CrimsonParser.AssignVariableContext ivdc = context.assignVariable();
            VariableAssignmentCStatement assignment;

            if (ivdc is CrimsonParser.AssignVariableDirectContext direct) assignment = VisitAssignVariableDirect(direct);
            else if (ivdc is CrimsonParser.AssignVariableAtPointerContext pointer) assignment = VisitAssignVariableAtPointer(pointer);
            else throw new CrimsonParserException("Cannot parse GlobalVariableDeclarationContext with unknown assignment type " + ivdc.GetType());

            return new GlobalVariableCStatement(assignment);
        }

        public override ScopeVariableCStatement VisitScopeVariableDeclaration ([NotNull] CrimsonParser.ScopeVariableDeclarationContext context)
        {
            FullNameCToken name = new FullNameCToken(context.name.Text);
            SimpleValueCToken size = VisitDatasize(context.size);

            return new ScopeVariableCStatement(name, size);
        }

        public override object VisitScopeVariableStatement ([NotNull] CrimsonParser.ScopeVariableStatementContext context)
        {
            return VisitScopeVariableDeclaration(context.scopeVariableDeclaration());
        }

        public override FunctionCStatement VisitFunctionDeclaration ([NotNull] CrimsonParser.FunctionDeclarationContext context)
        {
            FunctionCStatement.Header header = VisitFunctionHeader(context.header);
            Scope statements = VisitScope(context.body);
            return new FunctionCStatement(header, statements);

        }

        public override FunctionCStatement.Header VisitFunctionHeader ([NotNull] CrimsonParser.FunctionHeaderContext context)
        {
            FullNameCToken identifier = VisitFullName(context.name);
            List<FunctionCStatement.Parameter> parameters = VisitParameterList(context.parameters);
            return new FunctionCStatement.Header(identifier, parameters);
        }

        public override StructureCStatement VisitStructureDeclaration ([NotNull] CrimsonParser.StructureDeclarationContext context)
        {
            FullNameCToken identifier = VisitFullName(context.name);
            IList<AbstractCrimsonStatement> body = VisitStructureBody(context.structureBody());
            StructureCStatement structure = new StructureCStatement(identifier, body);
            return structure;
        }

        public override IList<AbstractCrimsonStatement> VisitStructureBody ([NotNull] CrimsonParser.StructureBodyContext context)
        {
            IList<AbstractCrimsonStatement> statements = new List<AbstractCrimsonStatement>();
            foreach (CrimsonParser.ScopeVariableDeclarationContext ivdCtx in context.scopeVariableDeclaration())
            {
                ScopeVariableCStatement var = VisitScopeVariableDeclaration(ivdCtx);
                statements.Add(var);
            }
            return statements;
        }

        public override object VisitArray ([NotNull] CrimsonParser.ArrayContext context)
        {
            return base.VisitArray(context);
        }

        public override SimpleValueCToken VisitDatasize ([NotNull] CrimsonParser.DatasizeContext context)
        {
            return VisitSimpleValue(context.sizeVal);
        }

        public VariableAssignmentCStatement ParseAssignVariable ([NotNull] CrimsonParser.AssignVariableContext context)
        {
            if (context == null) throw new StatementParseException("Illegal null CrimsonParser.AssignVariableContext", null, null);
            if (context is CrimsonParser.AssignVariableDirectContext avdc)
                return VisitAssignVariableDirect(avdc);
            else if (context is CrimsonParser.AssignVariableAtPointerContext avapc)
                return VisitAssignVariableAtPointer(avapc);
            else
                throw new StatementParseException("The given CrimsonParser.AssignVariableContext (" + context + ") is not of a permissable type", null, null);
        }

        public override List<FunctionCStatement.Parameter> VisitParameterList ([NotNull] CrimsonParser.ParameterListContext context)
        {
            List<FunctionCStatement.Parameter> parameters = new List<FunctionCStatement.Parameter>();
            foreach (CrimsonParser.ParameterContext paCtx in context.parameter())
            {
                FullNameCToken identifier = new FullNameCToken(paCtx.name.Text);
                SimpleValueCToken size = VisitDatasize(paCtx.size);
                FunctionCStatement.Parameter parameter = new FunctionCStatement.Parameter(size, identifier);
                parameters.Add(parameter);
            }
            return parameters;
        }

        // ----------------------------------------------------
        // ------------------------------------ STATEMENTS
        // ----------------------------------------------------

        public override FunctionCallCStatement VisitFunctionCall ([NotNull] CrimsonParser.FunctionCallContext context)
        {
            FullNameCToken identifier = VisitFullName(context.name);
            IList<SimpleValueCToken> arguments = VisitArguments(context.arguments());
            FunctionCallCStatement call = new FunctionCallCStatement(identifier, arguments);
            return call;
        }

        public override IfBlockCStatement VisitIfBlock ([NotNull] CrimsonParser.IfBlockContext context)
        {
            ConditionCToken condition = VisitCondition(context.condition());
            Scope scope = VisitScope(context.scope());
            CrimsonParser.ElseIfBlockContext eibCtx = context.elseIfBlock();
            CrimsonParser.ElseBlockContext elbCtx = context.elseBlock();
            ElseIfBlockCToken? elifBlock = eibCtx == null ? null : VisitElseIfBlock(eibCtx);
            ElseBlockCToken? elseBlock = elbCtx == null ? null : VisitElseBlock(elbCtx);
            IfBlockCStatement ifBlock = new IfBlockCStatement(condition, scope, elifBlock, elseBlock);
            return ifBlock;
        }

        public override WhileBlockCStatement VisitWhileBlock ([NotNull] CrimsonParser.WhileBlockContext context)
        {
            ConditionCToken condition = VisitCondition(context.condition());
            Scope body = VisitScope(context.scope());
            WhileBlockCStatement ifBlock = new WhileBlockCStatement(condition, body);
            return ifBlock;
        }

        public override VariableAssignmentCStatement VisitAssignVariableDirect ([NotNull] CrimsonParser.AssignVariableDirectContext context)
        {
            FullNameCToken identifier = new FullNameCToken(context.name.Text);
            SimpleValueCToken size = VisitDatasize(context.size);
            if (context.simple != null) return new VariableAssignmentCStatement(identifier, size, VisitSimpleValue(context.simple));
            else if (context.complex != null) return new VariableAssignmentCStatement(identifier, size, VisitComplexValue(context.complex));
            else throw new CrimsonParserException($"Cannot assign no value to variable {identifier}");
        }

        public override VariableAssignmentCStatement VisitAssignVariableAtPointer ([NotNull] CrimsonParser.AssignVariableAtPointerContext context)
        {
            //TODO AssignVariableAtPointer just adds an asterisk to the variable name
            FullNameCToken identifier = new FullNameCToken(context.name.Text);
            SimpleValueCToken size = VisitDatasize(context.size);
            if (context.simple != null) return new VariableAssignmentCStatement(identifier, size, VisitSimpleValue(context.simple));
            else if (context.complex != null) return new VariableAssignmentCStatement(identifier, size, VisitComplexValue(context.complex));
            else throw new CrimsonParserException($"Cannot assign no value to variable {identifier}");
        }

        public override ReturnCStatement VisitFunctionReturn ([NotNull] CrimsonParser.FunctionReturnContext context)
        {
            CrimsonParser.SimpleValueContext? rvc = context?.simpleValue();
            SimpleValueCToken value = rvc == null ? new RawResolvableValueCToken("NULL") : VisitSimpleValue(rvc);
            ReturnCStatement ret = new ReturnCStatement(value);
            return ret;
        }

        public override ComplexValueCToken VisitComplexValue ([NotNull] CrimsonParser.ComplexValueContext context)
        {
            if (context.op != null) return VisitOperation(context.op);
            else if (context.func != null) return new FunctionCallResolvableValueCToken(VisitFunctionCall(context.func));
            throw new CrimsonParserException("Cannot parse ComplexValueContext " + context.GetText());
        }

        public override SimpleValueCToken VisitSimpleValue ([NotNull] CrimsonParser.SimpleValueContext context)
        {
            if (context.id != null) return new IdentifierSimpleValueCToken(VisitFullName(context.id));
            else if (context.raw != null) return VisitRawValue(context.raw);
            throw new CrimsonParserException("Cannot parse SimpleValueContext " + context.GetText());
        }

        public override RawResolvableValueCToken VisitRawValue ([NotNull] CrimsonParser.RawValueContext context)
        {
            return new RawResolvableValueCToken(context.GetText());
        }

        public override OperationResolvableValueCToken VisitOperation ([NotNull] CrimsonParser.OperationContext context)
        {
            SimpleValueCToken leftToken = VisitSimpleValue(context.leftValue);
            OperationResolvableValueCToken.OperationType t = OperationResolvableValueCToken.ParseOpType(context.@operator.Text);
            SimpleValueCToken rightToken = VisitSimpleValue(context.rightValue);

            OperationResolvableValueCToken oct = new OperationResolvableValueCToken(leftToken, t, rightToken);
            return oct;
            // return new ResolvableValueCToken(context.GetText(), ResolvableValueCToken.ValueType.OPERATION);
        }

        public override BasicCallCStatement VisitBasicCall ([NotNull] CrimsonParser.BasicCallContext context)
        {
            string basicText = context.basicText.Text;
            BasicCallCStatement call = new BasicCallCStatement(basicText.Replace("\"", ""));
            return call;
        }

        public override AssemblyCallCStatement VisitAssemblyCall ([NotNull] CrimsonParser.AssemblyCallContext context)
        {
            string assemblyText = context.assemblyText.Text;
            AssemblyCallCStatement call = new AssemblyCallCStatement(assemblyText.Replace("\"", ""));
            return call;
        }

        public override IList<SimpleValueCToken> VisitArguments ([NotNull] CrimsonParser.ArgumentsContext context)
        {
            IList<SimpleValueCToken> arguments = new List<SimpleValueCToken>();
            foreach (CrimsonParser.SimpleValueContext rvlCxt in context.simpleValue())
            {
                SimpleValueCToken value = VisitSimpleValue(rvlCxt);
                arguments.Add(value);
            }
            return arguments;
        }

        public override ConditionCToken VisitCondition ([NotNull] CrimsonParser.ConditionContext context)
        {
            OperationResolvableValueCToken operation = VisitOperation(context.op);
            ConditionCToken condition = new ConditionCToken(operation);
            return condition;
        }

        public override ElseIfBlockCToken VisitElseIfBlock ([NotNull] CrimsonParser.ElseIfBlockContext context)
        {
            IfBlockCStatement ifBlock = VisitIfBlock(context.ifBlock());
            ElseIfBlockCToken elseIfBlock = new ElseIfBlockCToken(ifBlock);
            return elseIfBlock;
        }

        public override ElseBlockCToken VisitElseBlock ([NotNull] CrimsonParser.ElseBlockContext context)
        {
            Scope statements = VisitScope(context.scope());
            ElseBlockCToken elseBlock = new ElseBlockCToken(statements);
            return elseBlock;
        }

        public override FullNameCToken VisitFullName ([NotNull] CrimsonParser.FullNameContext context)
        {
            return new FullNameCToken(context.libraryName != null ? context.libraryName.Text : "", context.memberName.Text);
        }
    }
}
