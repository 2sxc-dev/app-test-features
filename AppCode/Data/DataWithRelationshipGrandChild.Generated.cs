// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "DataWithRelationshipGrandChild.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class DataWithRelationshipGrandChild
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.03.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-02 17:54:06Z
namespace AppCode.Data
{
  // This is a generated class for DataWithRelationshipGrandChild
  // To extend/modify it, see instructions above.

  /// <summary>
  /// DataWithRelationshipGrandChild data. <br/>
  /// Generated 2024-03-02 17:54:06Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Title`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class DataWithRelationshipGrandChild: AutoGenerated.ZagDataWithRelationshipGrandChild
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for DataWithRelationshipGrandChild in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagDataWithRelationshipGrandChild: Custom.Data.CustomItem
  {
    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}