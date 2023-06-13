//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/arall/PatchManager/src/PatchManager.SassyPatching/SassyPatchGrammar\sassy_parser.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SassyPatchGrammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="sassy_parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface Isassy_parserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.patch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPatch([NotNull] sassy_parser.PatchContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.top_level_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop_level_statement([NotNull] sassy_parser.Top_level_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.import_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImport_declaration([NotNull] sassy_parser.Import_declarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.var_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar_decl([NotNull] sassy_parser.Var_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.stage_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStage_def([NotNull] sassy_parser.Stage_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.function_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_def([NotNull] sassy_parser.Function_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.mixin_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMixin_def([NotNull] sassy_parser.Mixin_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.top_level_conditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop_level_conditional([NotNull] sassy_parser.Top_level_conditionalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.top_level_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop_level_else([NotNull] sassy_parser.Top_level_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.top_level_else_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop_level_else_else([NotNull] sassy_parser.Top_level_else_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.top_level_else_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop_level_else_if([NotNull] sassy_parser.Top_level_else_ifContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.selection_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelection_block([NotNull] sassy_parser.Selection_blockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.attributed_selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttributed_selector([NotNull] sassy_parser.Attributed_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>require_mod</c>
	/// labeled alternative in <see cref="sassy_parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequire_mod([NotNull] sassy_parser.Require_modContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>require_not_mod</c>
	/// labeled alternative in <see cref="sassy_parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequire_not_mod([NotNull] sassy_parser.Require_not_modContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>run_at_stage</c>
	/// labeled alternative in <see cref="sassy_parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRun_at_stage([NotNull] sassy_parser.Run_at_stageContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_element</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_element([NotNull] sassy_parser.Sel_elementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_ruleset</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_ruleset([NotNull] sassy_parser.Sel_rulesetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_child</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_child([NotNull] sassy_parser.Sel_childContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_add_element</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_add_element([NotNull] sassy_parser.Sel_add_elementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_class</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_class([NotNull] sassy_parser.Sel_classContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_name</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_name([NotNull] sassy_parser.Sel_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_intersection</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_intersection([NotNull] sassy_parser.Sel_intersectionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_everything</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_everything([NotNull] sassy_parser.Sel_everythingContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_without_class</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_without_class([NotNull] sassy_parser.Sel_without_classContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_without_name</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_without_name([NotNull] sassy_parser.Sel_without_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_combination</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_combination([NotNull] sassy_parser.Sel_combinationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sel_sub</c>
	/// labeled alternative in <see cref="sassy_parser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_sub([NotNull] sassy_parser.Sel_subContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ruleset_selector</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleset_selector([NotNull] sassy_parser.Ruleset_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>combination_selector</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCombination_selector([NotNull] sassy_parser.Combination_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>without_name</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithout_name([NotNull] sassy_parser.Without_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sub_selector</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSub_selector([NotNull] sassy_parser.Sub_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>class_selector</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClass_selector([NotNull] sassy_parser.Class_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>without_class</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithout_class([NotNull] sassy_parser.Without_classContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] sassy_parser.NameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>add_element</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd_element([NotNull] sassy_parser.Add_elementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>everything</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEverything([NotNull] sassy_parser.EverythingContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>intersection_selector</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntersection_selector([NotNull] sassy_parser.Intersection_selectorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>element</c>
	/// labeled alternative in <see cref="sassy_parser.selector_no_children"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] sassy_parser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.selector_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelector_body([NotNull] sassy_parser.Selector_bodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.selector_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelector_statement([NotNull] sassy_parser.Selector_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.sel_level_conditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_level_conditional([NotNull] sassy_parser.Sel_level_conditionalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.sel_level_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_level_else([NotNull] sassy_parser.Sel_level_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.sel_level_else_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_level_else_else([NotNull] sassy_parser.Sel_level_else_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.sel_level_else_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSel_level_else_if([NotNull] sassy_parser.Sel_level_else_ifContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.set_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSet_value([NotNull] sassy_parser.Set_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.delete_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_value([NotNull] sassy_parser.Delete_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.merge_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMerge_value([NotNull] sassy_parser.Merge_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>element_key_field</c>
	/// labeled alternative in <see cref="sassy_parser.field_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement_key_field([NotNull] sassy_parser.Element_key_fieldContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string_key_field</c>
	/// labeled alternative in <see cref="sassy_parser.field_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_key_field([NotNull] sassy_parser.String_key_fieldContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>number_indexor</c>
	/// labeled alternative in <see cref="sassy_parser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber_indexor([NotNull] sassy_parser.Number_indexorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>element_indexor</c>
	/// labeled alternative in <see cref="sassy_parser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement_indexor([NotNull] sassy_parser.Element_indexorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>class_indexor</c>
	/// labeled alternative in <see cref="sassy_parser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClass_indexor([NotNull] sassy_parser.Class_indexorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string_indexor</c>
	/// labeled alternative in <see cref="sassy_parser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_indexor([NotNull] sassy_parser.String_indexorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>implicit_add</c>
	/// labeled alternative in <see cref="sassy_parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplicit_add([NotNull] sassy_parser.Implicit_addContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>implicit_subtract</c>
	/// labeled alternative in <see cref="sassy_parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplicit_subtract([NotNull] sassy_parser.Implicit_subtractContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>implicit_multiply</c>
	/// labeled alternative in <see cref="sassy_parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplicit_multiply([NotNull] sassy_parser.Implicit_multiplyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>implicit_divide</c>
	/// labeled alternative in <see cref="sassy_parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplicit_divide([NotNull] sassy_parser.Implicit_divideContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>normal</c>
	/// labeled alternative in <see cref="sassy_parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNormal([NotNull] sassy_parser.NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>not_equal_to</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNot_equal_to([NotNull] sassy_parser.Not_equal_toContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>variable_reference</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable_reference([NotNull] sassy_parser.Variable_referenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>equal_to</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqual_to([NotNull] sassy_parser.Equal_toContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>indexor</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexor([NotNull] sassy_parser.IndexorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>or</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOr([NotNull] sassy_parser.OrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>member_call_ruleset</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMember_call_ruleset([NotNull] sassy_parser.Member_call_rulesetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>value_reference</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue_reference([NotNull] sassy_parser.Value_referenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lesser_than_equal</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLesser_than_equal([NotNull] sassy_parser.Lesser_than_equalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubtraction([NotNull] sassy_parser.SubtractionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>positive</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPositive([NotNull] sassy_parser.PositiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>simple_call</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_call([NotNull] sassy_parser.Simple_callContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivision([NotNull] sassy_parser.DivisionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>negative</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegative([NotNull] sassy_parser.NegativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>not</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNot([NotNull] sassy_parser.NotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lesser_than</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLesser_than([NotNull] sassy_parser.Lesser_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>member_call</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMember_call([NotNull] sassy_parser.Member_callContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>greater_than</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreater_than([NotNull] sassy_parser.Greater_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnd([NotNull] sassy_parser.AndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>sub_sub_expression</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSub_sub_expression([NotNull] sassy_parser.Sub_sub_expressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplication([NotNull] sassy_parser.MultiplicationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>remainder</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRemainder([NotNull] sassy_parser.RemainderContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>greater_than_equal</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreater_than_equal([NotNull] sassy_parser.Greater_than_equalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ternary</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernary([NotNull] sassy_parser.TernaryContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="sassy_parser.sub_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddition([NotNull] sassy_parser.AdditionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>value_deletion</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue_deletion([NotNull] sassy_parser.Value_deletionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolean_true</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean_true([NotNull] sassy_parser.Boolean_trueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolean_false</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean_false([NotNull] sassy_parser.Boolean_falseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>number_value</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber_value([NotNull] sassy_parser.Number_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string_value</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_value([NotNull] sassy_parser.String_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>none</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNone([NotNull] sassy_parser.NoneContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>closure</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClosure([NotNull] sassy_parser.ClosureContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>list_value</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_value([NotNull] sassy_parser.List_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>object_value</c>
	/// labeled alternative in <see cref="sassy_parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObject_value([NotNull] sassy_parser.Object_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] sassy_parser.ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.list_values"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_values([NotNull] sassy_parser.List_valuesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.obj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObj([NotNull] sassy_parser.ObjContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.obj_values"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObj_values([NotNull] sassy_parser.Obj_valuesContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>literal_key</c>
	/// labeled alternative in <see cref="sassy_parser.key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral_key([NotNull] sassy_parser.Literal_keyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string_key</c>
	/// labeled alternative in <see cref="sassy_parser.key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_key([NotNull] sassy_parser.String_keyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument_list([NotNull] sassy_parser.Argument_listContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>named_argument</c>
	/// labeled alternative in <see cref="sassy_parser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamed_argument([NotNull] sassy_parser.Named_argumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>unnamed_argument</c>
	/// labeled alternative in <see cref="sassy_parser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnnamed_argument([NotNull] sassy_parser.Unnamed_argumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.arg_decl_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArg_decl_list([NotNull] sassy_parser.Arg_decl_listContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argument_without_default</c>
	/// labeled alternative in <see cref="sassy_parser.arg_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument_without_default([NotNull] sassy_parser.Argument_without_defaultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argument_with_default</c>
	/// labeled alternative in <see cref="sassy_parser.arg_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument_with_default([NotNull] sassy_parser.Argument_with_defaultContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_body([NotNull] sassy_parser.Function_bodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.function_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_statement([NotNull] sassy_parser.Function_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.fn_level_conditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFn_level_conditional([NotNull] sassy_parser.Fn_level_conditionalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.fn_level_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFn_level_else([NotNull] sassy_parser.Fn_level_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.fn_level_else_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFn_level_else_else([NotNull] sassy_parser.Fn_level_else_elseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.fn_level_else_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFn_level_else_if([NotNull] sassy_parser.Fn_level_else_ifContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.fn_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFn_return([NotNull] sassy_parser.Fn_returnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.mixin_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMixin_include([NotNull] sassy_parser.Mixin_includeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>for_to_loop</c>
	/// labeled alternative in <see cref="sassy_parser.for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor_to_loop([NotNull] sassy_parser.For_to_loopContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>for_through_loop</c>
	/// labeled alternative in <see cref="sassy_parser.for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor_through_loop([NotNull] sassy_parser.For_through_loopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.each_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEach_loop([NotNull] sassy_parser.Each_loopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sassy_parser.while_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile_loop([NotNull] sassy_parser.While_loopContext context);
}
} // namespace SassyPatchGrammar
