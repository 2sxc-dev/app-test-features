// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FormulaParametersFromSettings.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FormulaParametersFromSettings
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-04 13:17:54Z
namespace AppCode.Data
{
  // This is a generated class for FormulaParametersFromSettings 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FormulaParametersFromSettings data. <br/>
  /// Generated 2024-03-04 13:17:54Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Title`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FormulaParametersFromSettings: AutoGenerated.ZagFormulaParametersFromSettings
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FormulaParametersFromSettings in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFormulaParametersFromSettings: Custom.Data.CustomItem
  {
    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}