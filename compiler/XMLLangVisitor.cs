using System;
using System.Text;
using System.Collections.Generic;

using Antlr4.Runtime.Misc;
using System.Linq;

namespace xmllang
{
    public class XMLLangVisitor : xmllangBaseVisitor<object>
    {
        public StringBuilder Content { get; set; }
        public HashSet<string> FunctionNames { get; }
        public IDictionary<string, string> TypeMap { get; }
        public IDictionary<string, VarScope> VarScopes { get; }
        public IDictionary<string, Function> Functions { get; }

        public VarScope CurrentVarScope { get; set; }
        public Function CurrentFunction { get; set; }

        public XMLLangVisitor()
        {
            Content = new StringBuilder("using System;\nusing System.Linq;" +
                "\nusing System.IO;\nusing System.Collections.Generic;\nusing xmllang;\n\n");

            VarScopes = new Dictionary<string, VarScope>();
            Functions = new Dictionary<string, Function>();
            TypeMap = new Dictionary<string, string>
            {
                { "node", nameof(XMLNode) },
                { "document", "Document" },
                { "attr", nameof(XMLAttribute) }
            };
        }

        public override object VisitTale([NotNull] xmllangParser.TaleContext context)
        {
            Content.Append("namespace xmllang_compiled\n{\n\tpublic class Tale\n\t{\n");

            VisitChildren(context);

            foreach (var function in Functions)
            {
                Content.Append("\t\t").Append(function.Value.Content);
            }

            Content.Append("\t}\n}\n");
            return Content;
        }

        public override object VisitTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context)
        {
            TypeMap.TryGetValue(context.TAG().ToString(), out var type);
            var varName = context.ID().ToString();

            if (CurrentVarScope.GetVarValue(varName) != null)
            {
                throw new Exception(VisitorExceptionMessages.VarAlreadyExists);
            }
            var tagName = context.STRING().ToString();

            CurrentVarScope.CreateVar(varName, type, new XMLNode(tagName));
            CurrentFunction.Content.Append($"var {varName} = new {type}({tagName});\n");

            return VisitChildren(context);
        }

        public override object VisitAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context)
        {
            TypeMap.TryGetValue(context.ATTR().ToString(), out var type);
            var varName = context.ID().ToString();

            if (CurrentVarScope.GetVarValue(varName) != null)
            {
                throw new Exception(VisitorExceptionMessages.VarAlreadyExists);
            }

            // TODO: split to args var
            var attrName = context.STRING(0).ToString();
            var attrValue = context.STRING(1).ToString();
            CurrentVarScope.CreateVar(varName, type, new XMLAttribute(attrName, attrValue));

            CurrentFunction.Content.Append($"var {varName} = new {type}({attrName}, {attrValue});\n");

            return VisitChildren(context);
        }

        public override object VisitGen_file([NotNull] xmllangParser.Gen_fileContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitParse_file([NotNull] xmllangParser.Parse_fileContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAdd_text([NotNull] xmllangParser.Add_textContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAppend_tag([NotNull] xmllangParser.Append_tagContext context)
        {
            CurrentFunction.Content.Append($"{context.ID()[0]}.{nameof(XMLNode.Children)}.Append({context.ID(1)});\n");

            return VisitChildren(context);
        }

        public override object VisitAppend_atr([NotNull] xmllangParser.Append_atrContext context)
        {
            CurrentFunction.Content.Append($"{context.ID(0)}.{nameof(XMLNode.Attributes)}.Append({context.ID(1)});\n");

            return VisitChildren(context);
        }

        public override object VisitRemove_tag([NotNull] xmllangParser.Remove_tagContext context)
        {
            CurrentFunction.Content.Append($"{context.ID(0)}.{nameof(XMLNode.Children)} = " +
                $"{context.ID(0)}.{nameof(XMLNode.Children)}" +
                $".Where(n => !n.Name.Equals({context.ID(1)}));\n");

            return VisitChildren(context);
        }

        public override object VisitRemove_atr([NotNull] xmllangParser.Remove_atrContext context)
        {
            CurrentFunction.Content.Append($"{context.ID(0)}.{nameof(XMLNode.Attributes)} = " +
                $"{context.ID(0)}.{nameof(XMLNode.Attributes)}" +
                $".Where(n => !n.Name.Equals({context.ID(1)}));\n");

            return VisitChildren(context);
        }

        public override object VisitDeclare_array([NotNull] xmllangParser.Declare_arrayContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitFor_cycle([NotNull] xmllangParser.For_cycleContext context)
        {
            return VisitChildren(context);
        }

        #region Function

        public override object VisitFunction_declaration([NotNull] xmllangParser.Function_declarationContext context)
        {
            var prevScopeName = CurrentVarScope?.Name;

            var result = VisitChildren(context);

            VarScopes.Add(CurrentVarScope.Name, new VarScope(CurrentVarScope.Name, CurrentVarScope.Vars));
            Functions.Add(CurrentFunction.Name, new Function
            {
                Name = CurrentFunction.Name,
                Content = CurrentFunction.Content
            });
            CurrentFunction.Content.Append("\t\t}\n");

            if (!string.IsNullOrEmpty(prevScopeName))
            {
                VarScopes.TryGetValue(prevScopeName, out var prevScope);
                Functions.TryGetValue(prevScopeName, out var prevFunction);
                CurrentVarScope = prevScope;
                CurrentFunction = prevFunction;
            }

            return result;
        }

        public override object VisitFunction_decl([NotNull] xmllangParser.Function_declContext context)
        {
            var functionName = context.ID().ToString();
            Functions.TryGetValue(functionName, out var function);

            if (function != null)
            {
                throw new Exception(VisitorExceptionMessages.AlreadyDefinedFunction);
            }

            CurrentFunction = new Function
            {
                Name = functionName,
                Content = new StringBuilder($"public static void {functionName}(")
            };
            CurrentVarScope = new VarScope(CurrentFunction.Name);

            return VisitChildren(context);
        }

        public override object VisitFunction_args([NotNull] xmllangParser.Function_argsContext context)
        {
            var argsCount = context.ID().Length;

            foreach (var name in context.ID())
            {
                foreach (var type in context.datatype())
                {
                    var stringified = type.Start.Text;
                    TypeMap.TryGetValue(stringified, out var realType);

                    CurrentFunction.Content.Append($"{realType} {name}, ");
                }
            }

            if (argsCount > 0)
            {
                CurrentFunction.Content.Remove(CurrentFunction.Content.Length - 2, 2);
            }
            CurrentFunction.Content.Append(")\n\t\t{\n");

            return VisitChildren(context);
        }

        public override object VisitFunction_call([NotNull] xmllangParser.Function_callContext context)
        {
            var functionName = context.ID()[0].ToString();
            Functions.TryGetValue(functionName, out var function);

            if (function == null)
            {
                throw new Exception(VisitorExceptionMessages.UndefinedFunction);
            }

            CurrentFunction.Content.Append($"{functionName}(");

            foreach (var arg in context.ID().TakeLast(context.ID().Length - 1))
            {
                CurrentFunction.Content.Append($"{arg.ToString()}, ");
            }

            CurrentFunction.Content.Remove(CurrentFunction.Content.Length - 2, 2).Append($");\n");
            return VisitChildren(context);
        }

        #endregion

        public override object VisitIf_declaration([NotNull] xmllangParser.If_declarationContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitPrint([NotNull] xmllangParser.PrintContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAccess_name([NotNull] xmllangParser.Access_nameContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAccess_text([NotNull] xmllangParser.Access_textContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitAccess_value([NotNull] xmllangParser.Access_valueContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitCaseId([NotNull] xmllangParser.CaseIdContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitCaseStr([NotNull] xmllangParser.CaseStrContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitCaseInt([NotNull] xmllangParser.CaseIntContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitCase_block([NotNull] xmllangParser.Case_blockContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitPrint_statement([NotNull] xmllangParser.Print_statementContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitBegin_for([NotNull] xmllangParser.Begin_forContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitEnd([NotNull] xmllangParser.EndContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitDatatype([NotNull] xmllangParser.DatatypeContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitBegin_if([NotNull] xmllangParser.Begin_ifContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitComparison([NotNull] xmllangParser.ComparisonContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitElse_thing([NotNull] xmllangParser.Else_thingContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitSwitch_stat([NotNull] xmllangParser.Switch_statContext context)
        {
            return VisitChildren(context);
        }
    }
}
