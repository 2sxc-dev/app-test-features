// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppResourcesModel.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppResourcesModel
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
  // This is a generated custom model class for AppResources (scope: System.App)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppResources custom model. <br/>
  /// Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// This is a lightweight model that inherits from CustomModel. <br/>
  /// For properties, use the strongly-typed access such as `.SomeLogo`. <br/>
  /// For advanced features, consider using the full CustomItem instead.
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.App.
  /// </remarks>
  public partial class AppResourcesModel: AutoGenerated.ZAutoGenAppResourcesModel
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.App.AppResourcesModel in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenAppResourcesModel: Custom.Data.CustomModel
  {
    /// <summary>
    /// SomeLogo as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("SomeLogo")
    /// </summary>
    public string SomeLogo => _item.Url("SomeLogo");

    /// <summary>
    /// Get the file object for SomeLogo - or null if it's empty or not referencing a file.
    /// </summary>

    [JsonIgnore]
    public IFile SomeLogoFile => _item.File("SomeLogo");

    /// <summary>
    /// Get the folder object for SomeLogo.
    /// </summary>

    [JsonIgnore]
    public IFolder SomeLogoFolder => _item.Folder("SomeLogo");

    /// <summary>
    /// WysiwygDescription as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("WysiwygDescription", scrubHtml: true) etc.
    /// </summary>
    public string WysiwygDescription => _item.String("WysiwygDescription", fallback: "");
  }
}