// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ForPrefillTestsCategories.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ForPrefillTestsCategories
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.04.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-19 22:27:34Z
namespace AppCode.Data
{
  // This is a generated class for ForPrefillTestsCategories 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ForPrefillTestsCategories data. <br/>
  /// Generated 2024-03-19 22:27:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Name`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class ForPrefillTestsCategories: AutoGenerated.ZagForPrefillTestsCategories
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.ForPrefillTestsCategories in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagForPrefillTestsCategories: Custom.Data.CustomItem
  {
    /// <summary>
    /// Name as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Name", scrubHtml: true) etc.
    /// </summary>
    public string Name => _item.String("Name", fallback: "");
  }
}