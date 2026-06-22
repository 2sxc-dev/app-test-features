using ToSic.Razor.Blade;
using ToSic.Razor.Markup;
using ToSic.Sxc.Edit.Toolbar;

namespace AppCode.TestHelpers
{
  public class ToolbarTestHelper: Custom.Hybrid.CodeTyped
  {
    /// <summary>
    /// Show a test according to standard output
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <param name="showJson">Whether to show the JSON representation</param>
    /// <returns>The generated tag</returns>
    public ITag ShowLiAndToolbar(string message, IToolbarBuilder toolbar) =>
      TbTestAsTag(message, toolbar, false);
      
    /// <summary>
    /// Show a test according to standard output
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <param name="showJson">Whether to show the JSON representation</param>
    /// <returns>The generated tag</returns>
    public ITag TbTestAsTag(string message, IToolbarBuilder toolbar, bool showJson = true) =>
      Tag.Li(
        message + " ",
        toolbar.AsTag(),
        Tag.Br(),
        "JSON: ",
        Tag.Code(
          showJson ? toolbar.AsJson().ToString() : "(skipped for brevity)"
        ).Attr(toolbar),
        Tag.Hr()
      );

    /// <summary>
    /// Show a test according to standard output with a visible variation
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="variation">The variation to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <returns>The generated tag</returns>
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
        Tag.Hr()
      );
    }

    /// <summary>
    /// Show a test on a list item
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <returns>The generated tag</returns>
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