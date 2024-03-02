// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Dummy.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Dummy
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.03.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-02 17:54:06Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Dummy
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Dummy data. <br/>
  /// Generated 2024-03-02 17:54:06Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Body`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Dummy: AutoGenerated.ZagDummy
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Dummy in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagDummy: Custom.Data.CustomItem
  {
    /// <summary>
    /// Body as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Body", scrubHtml: true) etc.
    /// </summary>
    public string Body => _item.String("Body", fallback: "");

    /// <summary>
    /// FavoriteNumber as int. <br/>
    /// To get other types use methods such as .Decimal("FavoriteNumber")
    /// </summary>
    public int FavoriteNumber => _item.Int("FavoriteNumber");

    /// <summary>
    /// Image as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Image")
    /// </summary>
    public string Image => _item.Url("Image");

    /// <summary>
    /// Get the file object for Image - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile ImageFile => _item.File("ImageFile");

    /// <summary>
    /// Get the folder object for Image.
    /// </summary>
    public IFolder ImageFolder => _item.Folder("ImageFolder");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}