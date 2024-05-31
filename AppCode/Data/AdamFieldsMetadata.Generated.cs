// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AdamFieldsMetadata.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AdamFieldsMetadata
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.10.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-31 09:14:59Z
namespace AppCode.Data
{
  // This is a generated class for AdamFieldsMetadata 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AdamFieldsMetadata data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Category`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class AdamFieldsMetadata: AutoGenerated.ZAutoGenAdamFieldsMetadata
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.AdamFieldsMetadata in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenAdamFieldsMetadata: Custom.Data.CustomItem
  {
    /// <summary>
    /// Category as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Category", scrubHtml: true) etc.
    /// </summary>
    public string Category => _item.String("Category", fallback: "");

    /// <summary>
    /// Label as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Label", scrubHtml: true) etc.
    /// </summary>
    public string Label => _item.String("Label", fallback: "");
  }
}