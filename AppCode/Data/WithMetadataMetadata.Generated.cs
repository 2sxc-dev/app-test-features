// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "WithMetadataMetadata.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class WithMetadataMetadata
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
  // This is a generated class for WithMetadataMetadata
  // To extend/modify it, see instructions above.

  /// <summary>
  /// WithMetadataMetadata data. <br/>
  /// Generated 2024-02-29 21:35:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Age`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class WithMetadataMetadata: WithMetadataMetadataAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for WithMetadataMetadata.
  /// </summary>
  public abstract class WithMetadataMetadataAutoGenerated: Custom.Data.CustomItem
  {
    /// <summary>
    /// Age as int. <br/>
    /// To get other types use methods such as .Decimal("Age")
    /// </summary>
    public int Age => _item.Int("Age");

    /// <summary>
    /// Color as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Color", scrubHtml: true) etc.
    /// </summary>
    public string Color => _item.String("Color", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}