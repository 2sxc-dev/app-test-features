// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "DataAdam.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class DataAdam
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-04 13:17:54Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for DataAdam 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// DataAdam data. <br/>
  /// Generated 2024-03-04 13:17:54Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Library`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class DataAdam: AutoGenerated.ZagDataAdam
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.DataAdam in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagDataAdam: Custom.Data.CustomItem
  {
    /// <summary>
    /// Library as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Library")
    /// </summary>
    public string Library => _item.Url("Library");

    /// <summary>
    /// Get the file object for Library - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile LibraryFile => _item.File("LibraryFile");

    /// <summary>
    /// Get the folder object for Library.
    /// </summary>
    public IFolder LibraryFolder => _item.Folder("LibraryFolder");

    /// <summary>
    /// Single as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Single")
    /// </summary>
    public string Single => _item.Url("Single");

    /// <summary>
    /// Get the file object for Single - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile SingleFile => _item.File("SingleFile");

    /// <summary>
    /// Get the folder object for Single.
    /// </summary>
    public IFolder SingleFolder => _item.Folder("SingleFolder");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}