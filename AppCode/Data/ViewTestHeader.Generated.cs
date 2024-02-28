// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ViewTestHeader.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ViewTestHeader
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
  // This is a generated class for ViewTestHeader
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ViewTestHeader data. <br/>
  /// Generated 2024-02-27 11:12:18Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Title`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class ViewTestHeader: ViewTestHeaderAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for ViewTestHeader.
  /// </summary>
  public abstract class ViewTestHeaderAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public string Title => _myItem.String("Title", fallback: "");
  }
}