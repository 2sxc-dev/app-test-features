// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldValueWysiwyg.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldValueWysiwyg
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.04.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-18 16:01:34Z
namespace AppCode.Data
{
  // This is a generated class for FieldValueWysiwyg 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldValueWysiwyg data. <br/>
  /// Generated 2024-03-18 16:01:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Contents`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldValueWysiwyg: AutoGenerated.ZagFieldValueWysiwyg
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FieldValueWysiwyg in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFieldValueWysiwyg: Custom.Data.CustomItem
  {
    /// <summary>
    /// Contents as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Contents", scrubHtml: true) etc.
    /// </summary>
    public string Contents => _item.String("Contents", fallback: "");

    /// <summary>
    /// TestDescription as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("TestDescription", scrubHtml: true) etc.
    /// </summary>
    public string TestDescription => _item.String("TestDescription", fallback: "");

    /// <summary>
    /// TestId as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("TestId", scrubHtml: true) etc.
    /// </summary>
    public string TestId => _item.String("TestId", fallback: "");
  }
}