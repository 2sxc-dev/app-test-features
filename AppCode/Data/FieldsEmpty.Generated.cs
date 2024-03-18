// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldsEmpty.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldsEmpty
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
  // This is a generated class for FieldsEmpty 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldsEmpty data. <br/>
  /// Generated 2024-03-18 16:01:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.SomeField`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldsEmpty: AutoGenerated.ZagFieldsEmpty
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FieldsEmpty in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFieldsEmpty: Custom.Data.CustomItem
  {
    /// <summary>
    /// SomeField as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("SomeField", scrubHtml: true) etc.
    /// </summary>
    public string SomeField => _item.String("SomeField", fallback: "");

    /// <summary>
    /// SomeField2 as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("SomeField2", scrubHtml: true) etc.
    /// </summary>
    public string SomeField2 => _item.String("SomeField2", fallback: "");

    /// <summary>
    /// SomeField3 as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("SomeField3", scrubHtml: true) etc.
    /// </summary>
    public string SomeField3 => _item.String("SomeField3", fallback: "");

    /// <summary>
    /// SomeField4 as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("SomeField4", scrubHtml: true) etc.
    /// </summary>
    public string SomeField4 => _item.String("SomeField4", fallback: "");

    /// <summary>
    /// SomeField5 as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("SomeField5", scrubHtml: true) etc.
    /// </summary>
    public string SomeField5 => _item.String("SomeField5", fallback: "");
  }
}