// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppDataCreateUpdateDelete.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppDataCreateUpdateDelete
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.10.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-31 09:14:59Z
using System.Text.Json.Serialization;
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for AppDataCreateUpdateDelete 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppDataCreateUpdateDelete data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Boolean`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class AppDataCreateUpdateDelete: AutoGenerated.ZAutoGenAppDataCreateUpdateDelete
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.AppDataCreateUpdateDelete in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenAppDataCreateUpdateDelete: Custom.Data.CustomItem
  {
    /// <summary>
    /// Boolean as bool. <br/>
    /// To get nullable use .Get("Boolean") as bool?;
    /// </summary>
    public bool Boolean => _item.Bool("Boolean");

    /// <summary>
    /// BooleanTristate as bool. <br/>
    /// To get nullable use .Get("BooleanTristate") as bool?;
    /// </summary>
    public bool BooleanTristate => _item.Bool("BooleanTristate");

    /// <summary>
    /// Number as int. <br/>
    /// To get other types use methods such as .Decimal("Number")
    /// </summary>
    public int Number => _item.Int("Number");

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

    /// <summary>
    /// TodoImage as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("TodoImage")
    /// </summary>
    public string TodoImage => _item.Url("TodoImage");

    /// <summary>
    /// Get the file object for TodoImage - or null if it's empty or not referencing a file.
    /// </summary>

    [JsonIgnore]
    public IFile TodoImageFile => _item.File("TodoImage");

    /// <summary>
    /// Get the folder object for TodoImage.
    /// </summary>

    [JsonIgnore]
    public IFolder TodoImageFolder => _item.Folder("TodoImage");

    /// <summary>
    /// Wysiwyg as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Wysiwyg", scrubHtml: true) etc.
    /// </summary>
    public string Wysiwyg => _item.String("Wysiwyg", fallback: "");
  }
}