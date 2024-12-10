using ToSic.Razor.Blade;

public class ToolbarServiceTests: Custom.Hybrid.Code14
{
  // Show a test according to standard output
  public dynamic TbTestAsTag(string message, dynamic toolbar) {
    return Tag.Li(
      message + " ",
      toolbar.AsTag(),
      Tag.Br(),
      "JSON: ",
      Tag.Code(
        toolbar.AsJson()
      ).Attr(toolbar),
      // toolbar.AsJson(),
      Tag.Hr()
    );
  }

  // Show a test according to standard output
  public dynamic TbTestAsVisibleTag(string message, string variation, dynamic toolbar) {
    return Tag.Li(
      message + " (",
      Tag.Strong(variation),
      ")",
      toolbar.AsTag(),
      Tag.Br(),
      "JSON: ",
      Tag.Pre(
        toolbar.AsJson()
      ),
      // "JSON: ",
      // toolbar.AsJson(),
      Tag.Hr()
    );
  }


  public dynamic TbTestOnLi(string message, dynamic toolbar) {
    return Tag.Li(
      message + " ",
      Tag.Br(),
      "JSON: ",
      toolbar.AsJson(),
      Tag.Hr()
    ).Attr(toolbar);
  }

}