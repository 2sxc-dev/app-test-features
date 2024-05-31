// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TestTemplateService.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TestTemplateService
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
  // This is a generated class for TestTemplateService 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TestTemplateService data. <br/>
  /// Generated 2024-05-31 09:14:59Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Message`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TestTemplateService: AutoGenerated.ZAutoGenTestTemplateService
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TestTemplateService in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenTestTemplateService: Custom.Data.CustomItem
  {
    /// <summary>
    /// Message as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Message", scrubHtml: true) etc.
    /// </summary>
    public string Message => _item.String("Message", fallback: "");

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