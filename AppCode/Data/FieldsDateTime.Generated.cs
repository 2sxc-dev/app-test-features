// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldsDateTime.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldsDateTime
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-04 13:17:54Z
using System;

namespace AppCode.Data
{
  // This is a generated class for FieldsDateTime 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldsDateTime data. <br/>
  /// Generated 2024-03-04 13:17:54Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.DateAndTime`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldsDateTime: AutoGenerated.ZagFieldsDateTime
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FieldsDateTime in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFieldsDateTime: Custom.Data.CustomItem
  {
    /// <summary>
    /// DateAndTime as DateTime.
    /// </summary>
    public DateTime DateAndTime => _item.DateTime("DateAndTime");

    /// <summary>
    /// DateOnly as DateTime.
    /// </summary>
    public DateTime DateOnly => _item.DateTime("DateOnly");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}