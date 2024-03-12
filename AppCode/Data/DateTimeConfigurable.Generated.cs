// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "DateTimeConfigurable.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class DateTimeConfigurable
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
  // This is a generated class for DateTimeConfigurable 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// DateTimeConfigurable data. <br/>
  /// Generated 2024-03-04 13:17:54Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.DesiredDate`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class DateTimeConfigurable: AutoGenerated.ZagDateTimeConfigurable
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.DateTimeConfigurable in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagDateTimeConfigurable: Custom.Data.CustomItem
  {
    /// <summary>
    /// DesiredDate as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DesiredDate", scrubHtml: true) etc.
    /// </summary>
    public string DesiredDate => _item.String("DesiredDate", fallback: "");

    /// <summary>
    /// Hours as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Hours", scrubHtml: true) etc.
    /// </summary>
    public string Hours => _item.String("Hours", fallback: "");
  }
}