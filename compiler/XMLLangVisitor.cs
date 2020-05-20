using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace xmllang {
    public class XMLLangVisitor : xmllangBaseVisitor<object>
    {
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.tale"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitTale([NotNull] xmllangParser.TaleContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>tag_assignment</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitTag_assignment([NotNull] xmllangParser.Tag_assignmentContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>attr_assignment</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAttr_assignment([NotNull] xmllangParser.Attr_assignmentContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>gen_file</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitGen_file([NotNull] xmllangParser.Gen_fileContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>parse_file</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitParse_file([NotNull] xmllangParser.Parse_fileContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>add_text</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAdd_text([NotNull] xmllangParser.Add_textContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>append_tag</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAppend_tag([NotNull] xmllangParser.Append_tagContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>append_atr</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAppend_atr([NotNull] xmllangParser.Append_atrContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>remove_tag</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitRemove_tag([NotNull] xmllangParser.Remove_tagContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>remove_atr</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitRemove_atr([NotNull] xmllangParser.Remove_atrContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>declare_array</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitDeclare_array([NotNull] xmllangParser.Declare_arrayContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>for_cycle</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitFor_cycle([NotNull] xmllangParser.For_cycleContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>function_declaration</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitFunction_declaration([NotNull] xmllangParser.Function_declarationContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>function_call</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitFunction_call([NotNull] xmllangParser.Function_callContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>if_declaration</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitIf_declaration([NotNull] xmllangParser.If_declarationContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>assign_new_value</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAssign_new_value([NotNull] xmllangParser.Assign_new_valueContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>comment_fun</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitComment_fun([NotNull] xmllangParser.Comment_funContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>print</c>
		/// labeled alternative in <see cref="xmllangParser.statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitPrint([NotNull] xmllangParser.PrintContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>access_name</c>
		/// labeled alternative in <see cref="xmllangParser.access_info"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAccess_name([NotNull] xmllangParser.Access_nameContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>access_text</c>
		/// labeled alternative in <see cref="xmllangParser.access_info"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAccess_text([NotNull] xmllangParser.Access_textContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>access_value</c>
		/// labeled alternative in <see cref="xmllangParser.access_info"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitAccess_value([NotNull] xmllangParser.Access_valueContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>caseId</c>
		/// labeled alternative in <see cref="xmllangParser.value"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitCaseId([NotNull] xmllangParser.CaseIdContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>caseStr</c>
		/// labeled alternative in <see cref="xmllangParser.value"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitCaseStr([NotNull] xmllangParser.CaseStrContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by the <c>caseInt</c>
		/// labeled alternative in <see cref="xmllangParser.value"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitCaseInt([NotNull] xmllangParser.CaseIntContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.case_block"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitCase_block([NotNull] xmllangParser.Case_blockContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.print_statement"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitPrint_statement([NotNull] xmllangParser.Print_statementContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.begin_for"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitBegin_for([NotNull] xmllangParser.Begin_forContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.end"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitEnd([NotNull] xmllangParser.EndContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.datatype"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitDatatype([NotNull] xmllangParser.DatatypeContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.function_decl"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitFunction_decl([NotNull] xmllangParser.Function_declContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.begin_if"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitBegin_if([NotNull] xmllangParser.Begin_ifContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.comparison"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitComparison([NotNull] xmllangParser.ComparisonContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.else_thing"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitElse_thing([NotNull] xmllangParser.Else_thingContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.comment"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public override object VisitComment([NotNull] xmllangParser.CommentContext context) { return VisitChildren(context); }
		/// <summary>
		/// Visit a parse tree produced by <see cref="xmllangParser.switch_stat"/>.
		/// <para>
		/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
		/// on <paramref name="context"/>.
		/// </para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		/// <return>The visitor result.</return>
		public virtual object VisitSwitch_stat([NotNull] xmllangParser.Switch_statContext context) { return VisitChildren(context); }
    }
}
