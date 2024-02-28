// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldsStringWysiwygAll.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldsStringWysiwygAll
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-02-27 11:12:18Z
namespace AppCode.Data
{
  // This is a generated class for FieldsStringWysiwygAll
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldsStringWysiwygAll data. <br/>
  /// Generated 2024-02-27 11:12:18Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.DialogDefaultHtml`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldsStringWysiwygAll: FieldsStringWysiwygAllAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for FieldsStringWysiwygAll.
  /// </summary>
  public abstract class FieldsStringWysiwygAllAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// DialogDefaultHtml as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DialogDefaultHtml", scrubHtml: true) etc.
    /// </summary>
    public string DialogDefaultHtml => _myItem.String("DialogDefaultHtml", fallback: "");

    /// <summary>
    /// DialogPrefill as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DialogPrefill", scrubHtml: true) etc.
    /// </summary>
    public string DialogPrefill => _myItem.String("DialogPrefill", fallback: "");

    /// <summary>
    /// DisabledDialog as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DisabledDialog", scrubHtml: true) etc.
    /// </summary>
    public string DisabledDialog => _myItem.String("DisabledDialog", fallback: "");

    /// <summary>
    /// DisabledInline as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DisabledInline", scrubHtml: true) etc.
    /// </summary>
    public string DisabledInline => _myItem.String("DisabledInline", fallback: "");

    /// <summary>
    /// Ephemeral as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Ephemeral", scrubHtml: true) etc.
    /// </summary>
    public string Ephemeral => _myItem.String("Ephemeral", fallback: "");

    /// <summary>
    /// FormulaBasic as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("FormulaBasic", scrubHtml: true) etc.
    /// </summary>
    public string FormulaBasic => _myItem.String("FormulaBasic", fallback: "");

    /// <summary>
    /// InlineDefaultHtml as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineDefaultHtml", scrubHtml: true) etc.
    /// </summary>
    public string InlineDefaultHtml => _myItem.String("InlineDefaultHtml", fallback: "");

    /// <summary>
    /// InlinePrefill as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlinePrefill", scrubHtml: true) etc.
    /// </summary>
    public string InlinePrefill => _myItem.String("InlinePrefill", fallback: "");

    /// <summary>
    /// NoTranslate as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("NoTranslate", scrubHtml: true) etc.
    /// </summary>
    public string NoTranslate => _myItem.String("NoTranslate", fallback: "");
  }
}