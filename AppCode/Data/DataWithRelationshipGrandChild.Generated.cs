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

// Generator:   CSharpDataModelsGenerator v17.10.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-31 09:14:59Z
namespace AppCode.Data
{
  // This is a generated class for DataWithRelationshipGrandChild 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// DataWithRelationshipGrandChild data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Title`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class DataWithRelationshipGrandChild: AutoGenerated.ZAutoGenDataWithRelationshipGrandChild
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.DataWithRelationshipGrandChild in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenDataWithRelationshipGrandChild: Custom.Data.CustomItem
  {
    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");
  }
}