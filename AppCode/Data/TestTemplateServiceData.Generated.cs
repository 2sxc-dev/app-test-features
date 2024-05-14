// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TestTemplateServiceData.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TestTemplateServiceData
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.07.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-05-14 20:40:49Z
using System;

namespace AppCode.Data
{
  // This is a generated class for TestTemplateServiceData 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TestTemplateServiceData data. <br/>
  /// Generated 2024-05-14 20:40:49Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Age`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TestTemplateServiceData: AutoGenerated.ZAutoGenTestTemplateServiceData
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TestTemplateServiceData in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenTestTemplateServiceData: Custom.Data.CustomItem
  {
    /// <summary>
    /// Age as int. <br/>
    /// To get other types use methods such as .Decimal("Age")
    /// </summary>
    public int Age => _item.Int("Age");

    /// <summary>
    /// Birthday as DateTime.
    /// </summary>
    public DateTime Birthday => _item.DateTime("Birthday");

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