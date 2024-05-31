// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ViewSettingsDummy.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ViewSettingsDummy
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
  // This is a generated class for ViewSettingsDummy (scope: System.Configuration)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ViewSettingsDummy data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.SomeNumber`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.Configuration.
  /// </remarks>
  public partial class ViewSettingsDummy: AutoGenerated.ZAutoGenViewSettingsDummy
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.Configuration.ViewSettingsDummy in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenViewSettingsDummy: Custom.Data.CustomItem
  {
    /// <summary>
    /// SomeNumber as int. <br/>
    /// To get other types use methods such as .Decimal("SomeNumber")
    /// </summary>
    public int SomeNumber => _item.Int("SomeNumber");

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