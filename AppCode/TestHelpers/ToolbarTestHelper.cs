using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
using ToSic.Sxc.Edit.Toolbar;

namespace AppCode.TestHelpers
{
  public class ToolbarTestHelper: Custom.Hybrid.CodeTyped
  {
    // Show a test according to standard output
    public ITag TbTestAsTag(string message, IToolbarBuilder toolbar) {
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
    public ITag TbTestAsVisibleTag(string message, string variation, IToolbarBuilder toolbar) {
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


    public ITag TbTestOnLi(string message, IToolbarBuilder toolbar) {
      return Tag.Li(
        message + " ",
        Tag.Br(),
        "JSON: ",
        toolbar.AsJson(),
        Tag.Hr()
      ).Attr(toolbar);
    }

  }

}