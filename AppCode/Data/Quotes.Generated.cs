// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Quotes.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Quotes
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
  // This is a generated class for Quotes
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Quotes data. <br/>
  /// Generated 2024-02-29 21:35:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Author`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Quotes: QuotesAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for Quotes.
  /// </summary>
  public abstract class QuotesAutoGenerated: Custom.Data.CustomItem
  {
    /// <summary>
    /// Author as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Author", scrubHtml: true) etc.
    /// </summary>
    public string Author => _item.String("Author", fallback: "");

    /// <summary>
    /// Quote as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Quote", scrubHtml: true) etc.
    /// </summary>
    public string Quote => _item.String("Quote", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}