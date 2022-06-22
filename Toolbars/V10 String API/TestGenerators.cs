using ToSic.Sxc.Services;
using ToSic.Razor.Blade;

public class TestGenerators : Custom.Hybrid.Code12 {

  // Mainly used in prefill and metadata
  public dynamic TestBlock(string label, bool empty, string modifier) {
    // var modifierList = new [] { "toolbar=empty", modifier } ;
    var modifierList = empty 
        ? new [] { "toolbar=empty", modifier } 
        : new [] { modifier };

    return Tag.Div().Class("demobox").Wrap(
      Tag.H2(label),
      Edit.Toolbar(toolbar: modifierList).ToString()
    );
  }

  public dynamic LiJsMenuTest(string label, string toolbar) {
    toolbar = toolbar.Replace("`", "\"");
    return Tag.Li(
      label,
      toolbar,
      Tag.Ul().Class("sc-menu").Attr("toolbar", toolbar)
    );
  }
}
