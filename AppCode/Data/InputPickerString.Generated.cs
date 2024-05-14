// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "InputPickerString.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class InputPickerString
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.07.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-14 20:40:49Z
using System.Collections.Generic;
using ToSic.Sxc.Data;

namespace AppCode.Data
{
  // This is a generated class for InputPickerString 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// InputPickerString data. <br/>
  /// Generated 2024-05-14 20:40:49Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.PickerEntity`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class InputPickerString: AutoGenerated.ZAutoGenInputPickerString
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.InputPickerString in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenInputPickerString: Custom.Data.CustomItem
  {
    /// <summary>
    /// PickerEntity as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem PickerEntity => _pickerEntity ??= _item.Child("PickerEntity");
    private ITypedItem _pickerEntity;

    /// <summary>
    /// PickerString as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("PickerString", scrubHtml: true) etc.
    /// </summary>
    public string PickerString => _item.String("PickerString", fallback: "");
  }
}