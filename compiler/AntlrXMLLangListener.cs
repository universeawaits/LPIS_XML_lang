using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace xmllang {
    public class AntlrXMLLangListener : xmllangBaseListener
    {
        public override void EnterTale([NotNull] xmllangParser.TaleContext context) { }
        
		public override void ExitTale([NotNull] xmllangParser.TaleContext context) { }
        
		public override void EnterTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context) { }
        
		public override void ExitTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context) { }
        
		public override void EnterAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context) { }
        
		public override void ExitAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context) { }
        
		public override void EnterGen_file([NotNull] xmllangParser.Gen_fileContext context) { }
        
		public override void ExitGen_file([NotNull] xmllangParser.Gen_fileContext context) { }
        
		public override void EnterParse_file([NotNull] xmllangParser.Parse_fileContext context) { }
        
		public override void ExitParse_file([NotNull] xmllangParser.Parse_fileContext context) { }
        
		public override void EnterAdd_text([NotNull] xmllangParser.Add_textContext context) { }
        
		public override void ExitAdd_text([NotNull] xmllangParser.Add_textContext context) { }
        
		public override void EnterAppend_tag([NotNull] xmllangParser.Append_tagContext context) { }
        
		public override void ExitAppend_tag([NotNull] xmllangParser.Append_tagContext context) { }
        
		public override void EnterAppend_atr([NotNull] xmllangParser.Append_atrContext context) { }
        
		public override void ExitAppend_atr([NotNull] xmllangParser.Append_atrContext context) { }
        
		public override void EnterRemove_tag([NotNull] xmllangParser.Remove_tagContext context) { }
        
		public override void ExitRemove_tag([NotNull] xmllangParser.Remove_tagContext context) { }
        
		public override void EnterRemove_atr([NotNull] xmllangParser.Remove_atrContext context) { }
        
		public override void ExitRemove_atr([NotNull] xmllangParser.Remove_atrContext context) { }
        
		public override void EnterDeclare_array([NotNull] xmllangParser.Declare_arrayContext context) { }
        
		public override void ExitDeclare_array([NotNull] xmllangParser.Declare_arrayContext context) { }
        
		public override void EnterSearch_tag([NotNull] xmllangParser.Search_tagContext context) { }
        
		public override void ExitSearch_tag([NotNull] xmllangParser.Search_tagContext context) { }
        
		public override void EnterFor_cycle([NotNull] xmllangParser.For_cycleContext context) { }
        
		public override void ExitFor_cycle([NotNull] xmllangParser.For_cycleContext context) { }
        
		public override void EnterFunction_declaration([NotNull] xmllangParser.Function_declarationContext context) { }
        
		public override void ExitFunction_declaration([NotNull] xmllangParser.Function_declarationContext context) { }
        
		public override void EnterFunction_call([NotNull] xmllangParser.Function_callContext context) { }
        
		public override void ExitFunction_call([NotNull] xmllangParser.Function_callContext context) { }
        
		public override void EnterIf_declaration([NotNull] xmllangParser.If_declarationContext context) { }
        
		public override void ExitIf_declaration([NotNull] xmllangParser.If_declarationContext context) { }
        
		public override void EnterAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context) { }
        
		public override void ExitAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context) { }
        
		public override void EnterComment_fun([NotNull] xmllangParser.Comment_funContext context) { }
        
		public override void ExitComment_fun([NotNull] xmllangParser.Comment_funContext context) { }
        
		public override void EnterPrint([NotNull] xmllangParser.PrintContext context) { }
        
		public override void ExitPrint([NotNull] xmllangParser.PrintContext context) { }
        
		public override void EnterAccess_name([NotNull] xmllangParser.Access_nameContext context) { }
        
		public override void ExitAccess_name([NotNull] xmllangParser.Access_nameContext context) { }
        
		public override void EnterAccess_text([NotNull] xmllangParser.Access_textContext context) { }
        
		public override void ExitAccess_text([NotNull] xmllangParser.Access_textContext context) { }
        
		public override void EnterAccess_value([NotNull] xmllangParser.Access_valueContext context) { }
        
		public override void ExitAccess_value([NotNull] xmllangParser.Access_valueContext context) { }
        
		public override void EnterCaseId([NotNull] xmllangParser.CaseIdContext context) { }
        
		public override void ExitCaseId([NotNull] xmllangParser.CaseIdContext context) { }
        
		public override void EnterCaseStr([NotNull] xmllangParser.CaseStrContext context) { }
        
		public override void ExitCaseStr([NotNull] xmllangParser.CaseStrContext context) { }
        
		public override void EnterCaseInt([NotNull] xmllangParser.CaseIntContext context) { }
        
		public override void ExitCaseInt([NotNull] xmllangParser.CaseIntContext context) { }
        
		public override void EnterCase_block([NotNull] xmllangParser.Case_blockContext context) { }

        public override void ExitCase_block([NotNull] xmllangParser.Case_blockContext context) { }
                
		public override void EnterPrint_statement([NotNull] xmllangParser.Print_statementContext context) { }
        
		public override void ExitPrint_statement([NotNull] xmllangParser.Print_statementContext context) { }
        
		public override void EnterBegin_for([NotNull] xmllangParser.Begin_forContext context) { }
        
		public override void ExitBegin_for([NotNull] xmllangParser.Begin_forContext context) { }
        
		public override void EnterEnd([NotNull] xmllangParser.EndContext context) { }
        
		public override void ExitEnd([NotNull] xmllangParser.EndContext context) { }
        
		public override void EnterDatatype([NotNull] xmllangParser.DatatypeContext context) { }
        
		public override void ExitDatatype([NotNull] xmllangParser.DatatypeContext context) { }
        
		public override void EnterFunction_decl([NotNull] xmllangParser.Function_declContext context) { }
        
		public override void ExitFunction_decl([NotNull] xmllangParser.Function_declContext context) { }
        
		public override void EnterBegin_if([NotNull] xmllangParser.Begin_ifContext context) { }
        
		public override void ExitBegin_if([NotNull] xmllangParser.Begin_ifContext context) { }
        
		public override void EnterComparison([NotNull] xmllangParser.ComparisonContext context) { }
        
		public override void ExitComparison([NotNull] xmllangParser.ComparisonContext context) { }
        
		public override void EnterElse_thing([NotNull] xmllangParser.Else_thingContext context) { }
        
		public override void ExitElse_thing([NotNull] xmllangParser.Else_thingContext context) { }
        
		public override void EnterComment([NotNull] xmllangParser.CommentContext context) { }
        
		public override void ExitComment([NotNull] xmllangParser.CommentContext context) { }
        
		public override void EnterSwitch_stat([NotNull] xmllangParser.Switch_statContext context) { }
        
		public override void ExitSwitch_stat([NotNull] xmllangParser.Switch_statContext context) { }
    }
}
