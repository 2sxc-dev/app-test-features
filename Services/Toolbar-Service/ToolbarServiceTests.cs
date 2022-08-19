using ToSic.Razor.Blade;
using ToSic.Sxc.Services;
using System.Web;
using System.Linq;
using System.IO;

public class ToolbarServiceTests: Custom.Hybrid.Code14
{
  // Show a test according to standard output
  public dynamic TbTestAsTag(string message, dynamic toolbar) {
    return Tag.Li(
      message + " ",
      toolbar.AsTag(),
      Tag.Br(),
      "JSON: ",
      toolbar.AsJson(),
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