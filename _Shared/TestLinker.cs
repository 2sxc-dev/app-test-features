using ToSic.Sxc.Demo;
using ToSic.Razor.Blade;
using ToSic.Razor.Markup;

// Important notes: 
// - This class should have the same name as the file it's in
public class TestLinker : Custom.Hybrid.Code14 
{
  public ITag SubLinkWithIndicator(string paramName, string value, string title) {
    var pParams = CmsContext.Page.Parameters;
    var existingValue = pParams[paramName];
    var isSet = existingValue == value;
    return Tag.A()
      .Href(Kit.Link.To(parameters: value == null ? pParams.Remove(paramName) : pParams.Set(paramName, value)))
      .Wrap(
        title,
        " ",
        isSet ? "✅" : ""
      );
  }
}
