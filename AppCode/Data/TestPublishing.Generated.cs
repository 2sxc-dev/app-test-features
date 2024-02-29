// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TestPublishing.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TestPublishing
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-02-29 21:35:48Z
namespace AppCode.Data
{
  // This is a generated class for TestPublishing
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TestPublishing data. <br/>
  /// Generated 2024-02-29 21:35:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.TestId`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TestPublishing: TestPublishingAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for TestPublishing.
  /// </summary>
  public abstract class TestPublishingAutoGenerated: Custom.Data.CustomItem
  {
    /// <summary>
    /// TestId as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("TestId", scrubHtml: true) etc.
    /// </summary>
    public string TestId => _item.String("TestId", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}