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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="xmllangParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IxmllangVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.tale"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTale([NotNull] xmllangParser.TaleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tag_assignment</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>attr_assignment</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>gen_file</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGen_file([NotNull] xmllangParser.Gen_fileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parse_file</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse_file([NotNull] xmllangParser.Parse_fileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>add_text</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd_text([NotNull] xmllangParser.Add_textContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>append_tag</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAppend_tag([NotNull] xmllangParser.Append_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>append_atr</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAppend_atr([NotNull] xmllangParser.Append_atrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>remove_tag</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRemove_tag([NotNull] xmllangParser.Remove_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>remove_atr</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRemove_atr([NotNull] xmllangParser.Remove_atrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>declare_array</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclare_array([NotNull] xmllangParser.Declare_arrayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>for_cycle</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor_cycle([NotNull] xmllangParser.For_cycleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>function_declaration</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_declaration([NotNull] xmllangParser.Function_declarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>function_call</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_call([NotNull] xmllangParser.Function_callContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>if_declaration</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_declaration([NotNull] xmllangParser.If_declarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assign_new_value</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>comment_fun</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment_fun([NotNull] xmllangParser.Comment_funContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="xmllangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint([NotNull] xmllangParser.PrintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>access_name</c>
	/// labeled alternative in <see cref="xmllangParser.access_info"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccess_name([NotNull] xmllangParser.Access_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>access_text</c>
	/// labeled alternative in <see cref="xmllangParser.access_info"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccess_text([NotNull] xmllangParser.Access_textContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>access_value</c>
	/// labeled alternative in <see cref="xmllangParser.access_info"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccess_value([NotNull] xmllangParser.Access_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>caseId</c>
	/// labeled alternative in <see cref="xmllangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseId([NotNull] xmllangParser.CaseIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>caseStr</c>
	/// labeled alternative in <see cref="xmllangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseStr([NotNull] xmllangParser.CaseStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>caseInt</c>
	/// labeled alternative in <see cref="xmllangParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseInt([NotNull] xmllangParser.CaseIntContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.case_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCase_block([NotNull] xmllangParser.Case_blockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.print_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_statement([NotNull] xmllangParser.Print_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.begin_for"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBegin_for([NotNull] xmllangParser.Begin_forContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnd([NotNull] xmllangParser.EndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatatype([NotNull] xmllangParser.DatatypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.function_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_decl([NotNull] xmllangParser.Function_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.begin_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBegin_if([NotNull] xmllangParser.Begin_ifContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparison([NotNull] xmllangParser.ComparisonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.else_thing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElse_thing([NotNull] xmllangParser.Else_thingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] xmllangParser.CommentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="xmllangParser.switch_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitch_stat([NotNull] xmllangParser.Switch_statContext context);
}
} // namespace xmllang
