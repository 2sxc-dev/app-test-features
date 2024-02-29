// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldsStringWysiwyg.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldsStringWysiwyg
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-02-29 21:35:48Z
namespace AppCode.Data
{
  // This is a generated class for FieldsStringWysiwyg
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldsStringWysiwyg data. <br/>
  /// Generated 2024-02-29 21:35:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.CssBasic`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldsStringWysiwyg: FieldsStringWysiwygAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for FieldsStringWysiwyg.
  /// </summary>
  public abstract class FieldsStringWysiwygAutoGenerated: Custom.Data.CustomItem
  {
    /// <summary>
    /// CssBasic as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("CssBasic", scrubHtml: true) etc.
    /// </summary>
    public string CssBasic => _item.String("CssBasic", fallback: "");

    /// <summary>
    /// DialogDefault as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DialogDefault", scrubHtml: true) etc.
    /// </summary>
    public string DialogDefault => _item.String("DialogDefault", fallback: "");

    /// <summary>
    /// InlineDefault as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineDefault", scrubHtml: true) etc.
    /// </summary>
    public string InlineDefault => _item.String("InlineDefault", fallback: "");

    /// <summary>
    /// InlineLarge as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineLarge", scrubHtml: true) etc.
    /// </summary>
    public string InlineLarge => _item.String("InlineLarge", fallback: "");

    /// <summary>
    /// InlineMedium as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineMedium", scrubHtml: true) etc.
    /// </summary>
    public string InlineMedium => _item.String("InlineMedium", fallback: "");

    /// <summary>
    /// InlineMinimum as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineMinimum", scrubHtml: true) etc.
    /// </summary>
    public string InlineMinimum => _item.String("InlineMinimum", fallback: "");

    /// <summary>
    /// InlineNarrow as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineNarrow", scrubHtml: true) etc.
    /// </summary>
    public string InlineNarrow => _item.String("InlineNarrow", fallback: "");

    /// <summary>
    /// InlineNoAdvNoHtml as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineNoAdvNoHtml", scrubHtml: true) etc.
    /// </summary>
    public string InlineNoAdvNoHtml => _item.String("InlineNoAdvNoHtml", fallback: "");

    /// <summary>
    /// InlineNoDialog as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineNoDialog", scrubHtml: true) etc.
    /// </summary>
    public string InlineNoDialog => _item.String("InlineNoDialog", fallback: "");

    /// <summary>
    /// InlineWithAdvanced as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineWithAdvanced", scrubHtml: true) etc.
    /// </summary>
    public string InlineWithAdvanced => _item.String("InlineWithAdvanced", fallback: "");

    /// <summary>
    /// InlineWithAdvButNoHtml as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineWithAdvButNoHtml", scrubHtml: true) etc.
    /// </summary>
    public string InlineWithAdvButNoHtml => _item.String("InlineWithAdvButNoHtml", fallback: "");

    /// <summary>
    /// InlineWithHtml as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineWithHtml", scrubHtml: true) etc.
    /// </summary>
    public string InlineWithHtml => _item.String("InlineWithHtml", fallback: "");

    /// <summary>
    /// InlineWithHtmlAdvanced as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InlineWithHtmlAdvanced", scrubHtml: true) etc.
    /// </summary>
    public string InlineWithHtmlAdvanced => _item.String("InlineWithHtmlAdvanced", fallback: "");

    /// <summary>
    /// WysiwygWithConfigButDefault as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("WysiwygWithConfigButDefault", scrubHtml: true) etc.
    /// </summary>
    public string WysiwygWithConfigButDefault => _item.String("WysiwygWithConfigButDefault", fallback: "");

    /// <summary>
    /// WysiwygWithoutConfig as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("WysiwygWithoutConfig", scrubHtml: true) etc.
    /// </summary>
    public string WysiwygWithoutConfig => _item.String("WysiwygWithoutConfig", fallback: "");
  }
}