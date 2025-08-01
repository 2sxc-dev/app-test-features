// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ImageServiceTestsModel.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ImageServiceTestsModel
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpCustomModelsGenerator
// App/Edition: App Test Features/
// User:        2sichost
using System.Text.Json.Serialization;
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated custom model class for ImageServiceTests 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ImageServiceTests custom model. <br/>
  /// Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// This is a lightweight model that inherits from CustomModel. <br/>
  /// For properties, use the strongly-typed access such as `.Image`. <br/>
  /// For advanced features, consider using the full CustomItem instead.
  /// </summary>
  public partial class ImageServiceTestsModel: AutoGenerated.ZAutoGenImageServiceTestsModel
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.ImageServiceTestsModel in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenImageServiceTestsModel: Custom.Data.CustomModel
  {
    /// <summary>
    /// Image as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Image")
    /// </summary>
    public string Image => _item.Url("Image");

    /// <summary>
    /// Get the file object for Image - or null if it's empty or not referencing a file.
    /// </summary>

    [JsonIgnore]
    public IFile ImageFile => _item.File("Image");

    /// <summary>
    /// Get the folder object for Image.
    /// </summary>

    [JsonIgnore]
    public IFolder ImageFolder => _item.Folder("Image");

    /// <summary>
    /// ImageNoFieldConfig as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("ImageNoFieldConfig")
    /// </summary>
    public string ImageNoFieldConfig => _item.Url("ImageNoFieldConfig");

    /// <summary>
    /// Get the file object for ImageNoFieldConfig - or null if it's empty or not referencing a file.
    /// </summary>

    [JsonIgnore]
    public IFile ImageNoFieldConfigFile => _item.File("ImageNoFieldConfig");

    /// <summary>
    /// Get the folder object for ImageNoFieldConfig.
    /// </summary>

    [JsonIgnore]
    public IFolder ImageNoFieldConfigFolder => _item.Folder("ImageNoFieldConfig");

    /// <summary>
    /// TestId as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("TestId", scrubHtml: true) etc.
    /// </summary>
    public string TestId => _item.String("TestId", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public string Title => _item.String("Title", fallback: "");
  }
}