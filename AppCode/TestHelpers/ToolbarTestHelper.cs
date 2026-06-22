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
    public ITag LiAndToolbar(string message, IToolbarBuilder toolbar, bool showJson = false) =>
      LiToolbarAndJson(message, toolbar, showJson);
      
    /// <summary>
    /// Show a test according to standard output
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <param name="showJson">Whether to show the JSON representation</param>
    /// <returns>The generated tag</returns>
    public ITag LiToolbarAndJson(string message, IToolbarBuilder toolbar, bool showJson = true) =>
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
    public ITag LiToolbarAndJson(string message, string variation, IToolbarBuilder toolbar) {
      return Tag.Li(
        message + " (",
        Tag.Strong(variation),
        ")",
        toolbar.AsTag(),
        Tag.Br(),
        "JSON: ",
        Tag.Code(
          toolbar.AsJson()
        ),
        Tag.Hr()
      );
    }

    /// <summary>
    /// Show a test on a list item - but only on tag, so hover or not according to settings.
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="toolbar">The toolbar builder</param>
    /// <returns>The generated tag</returns>
    public ITag LiToolbarOnTagOnly(string message, IToolbarBuilder toolbar) {
      return Tag.Li(
        message + " ",
        Tag.Br(),
        "JSON: ",
        Tag.Code(toolbar.AsJson()),
        Tag.Hr()
      ).Attr(toolbar);
    }

  }

}