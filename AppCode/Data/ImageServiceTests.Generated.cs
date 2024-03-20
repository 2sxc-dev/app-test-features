// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ImageServiceTests.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ImageServiceTests
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.04.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-19 22:27:34Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for ImageServiceTests 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ImageServiceTests data. <br/>
  /// Generated 2024-03-19 22:27:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Image`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class ImageServiceTests: AutoGenerated.ZagImageServiceTests
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.ImageServiceTests in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagImageServiceTests: Custom.Data.CustomItem
  {
    /// <summary>
    /// Image as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Image")
    /// </summary>
    public string Image => _item.Url("Image");

    /// <summary>
    /// Get the file object for Image - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile ImageFile => _item.File("Image");

    /// <summary>
    /// Get the folder object for Image.
    /// </summary>
    public IFolder ImageFolder => _item.Folder("Image");

    /// <summary>
    /// TestId as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("TestId", scrubHtml: true) etc.
    /// </summary>
    public string TestId => _item.String("TestId", fallback: "");

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