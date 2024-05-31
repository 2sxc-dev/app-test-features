// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ViewTestDefault.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ViewTestDefault
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.10.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-31 09:14:59Z
using System.Collections.Generic;

namespace AppCode.Data
{
  // This is a generated class for ViewTestDefault 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ViewTestDefault data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.SubItems`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class ViewTestDefault: AutoGenerated.ZAutoGenViewTestDefault
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.ViewTestDefault in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenViewTestDefault: Custom.Data.CustomItem
  {
    /// <summary>
    /// SubItems as list of DataWithRelationshipChild.
    /// </summary>
    /// <remarks>
    /// Generated to return child-list child because field settings had Multi-Value=true. The type DataWithRelationshipChild was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// An IEnumerable of specified type, but can be empty.
    /// </returns>
    public IEnumerable<DataWithRelationshipChild> SubItems => _subItems ??= _item.Children<DataWithRelationshipChild>("SubItems");
    private IEnumerable<DataWithRelationshipChild> _subItems;

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