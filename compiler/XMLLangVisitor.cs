using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace xmllang {
    public class XMLLangVisitor : xmllangBaseVisitor<object>
    {
		public StringBuilder Content { get; set; }
		public IDictionary<string, VarScope> VarScopes { get; }
        public IDictionary<string, string> TypeMap { get; }

		public XMLLangVisitor()
		{
			Content = new StringBuilder("using System;\nusing System.IO;\nusing System.Collections.Generic;\nusing xmllang;\n");

			VarScopes = new Dictionary<string, VarScope>();
            TypeMap = new Dictionary<string, string>
            {
                { "node", "Node" },
                { "document", "Document" },
                { "attr", "Attibute" }
            };
		}

		public override object VisitTale([NotNull] xmllangParser.TaleContext context)
		{
			Content.Append("namespace xmllang_compiled\n{\npublic class Program\n{\npublic static void Main()\n{\n");
			VisitChildren(context);
            Content.Append("}\n}\n}\n");

            return Content;
        }

		public override object VisitTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context)
        {
            TypeMap.TryGetValue(context.TAG().ToString(), out var type);
            var id = context.ID();
            var tagName = context.STRING();

            Content
                .Append("var ").Append(id).Append(" = new ")
                .Append(type).Append("(").Append(tagName).Append(");\n");

            return VisitChildren(context);
        }

		public override object VisitAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context)
        {
            TypeMap.TryGetValue(context.ATTR().ToString(), out var type);
            var id = context.ID();
            var attrName = context.STRING()[0];
            var attrValue = context.STRING()[1];

            Content
                .Append("var ").Append(id).Append(" = new ")
                .Append(type).Append("(").Append(attrName).Append(", ").Append(attrValue).Append(");\n");

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
            return VisitChildren(context);
        }

		public override object VisitAppend_atr([NotNull] xmllangParser.Append_atrContext context) 
        {
            return VisitChildren(context);
        }
		
		public override object VisitRemove_tag([NotNull] xmllangParser.Remove_tagContext context) 
        {
            return VisitChildren(context);
        }

		public override object VisitRemove_atr([NotNull] xmllangParser.Remove_atrContext context) 
        {
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

		public override object VisitFunction_declaration([NotNull] xmllangParser.Function_declarationContext context) 
        {
            return VisitChildren(context);
        }

		public override object VisitFunction_call([NotNull] xmllangParser.Function_callContext context) 
        {
            return VisitChildren(context);
        }

		public override object VisitIf_declaration([NotNull] xmllangParser.If_declarationContext context) 
        {
            return VisitChildren(context);
        }


		public override object VisitAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context) 
        {
            return VisitChildren(context);
        }

		public override object VisitComment_fun([NotNull] xmllangParser.Comment_funContext context) 
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
			Console.WriteLine(Content);

            return VisitChildren(context);
        }

		public override object VisitDatatype([NotNull] xmllangParser.DatatypeContext context) 
        {
            return VisitChildren(context);
        }

		public override object VisitFunction_decl([NotNull] xmllangParser.Function_declContext context) 
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
		
		public override object VisitComment([NotNull] xmllangParser.CommentContext context) 
        {
            return VisitChildren(context);
        }
		
		public override object VisitSwitch_stat([NotNull] xmllangParser.Switch_statContext context) 
        {
            return VisitChildren(context);
        }
    }
}
