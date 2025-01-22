namespace AppCode.Data
{
  /// <summary>
  /// Auto-Generated base class for Default.Quotes in separate namespace and special name to avoid accidental use.
  /// </summary>
  public class QuotesModel: Custom.Data.CustomModel
  {
    public int Id => _item.Id;

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
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public /* new */ string Title => _item.String("Title", fallback: "");

    public QuotesModel Self => _self ??= As<QuotesModel>(this);
    private QuotesModel _self;
  }

  /// <summary>
  /// Dummy class with a longer name, which will not auto-find the stream even after removing "Model"
  /// </summary>
  public class QuoteIncorrectNameModel: QuotesModel
  { }

  /// <summary>
  /// Dummy class with a name after model, which won't be auto-truncated
  /// </summary>
  public class QuotesModelBadName: QuotesModel
  { }
}

