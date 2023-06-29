using ToSic.Sxc.Demo;
using ToSic.Razor.Blade;

public class RazorVersion : Custom.Hybrid.Code14 
{
  public IHtmlTag RazorWithVersionPicker(object page) {
    var tags = Kit.HtmlTags;
    var par = CmsContext.Page.Parameters.Remove("Razor12").Remove("Razor14").Remove("Razor16");
    return tags.RawHtml(
      "(Razor Version: ",
      page is Custom.Hybrid.Razor12 ? tags.U("12") as IHtmlTag: tags.A("12").Href(Link.To(parameters: par.Set("Razor12", "true"))),
      " ",
      page is Custom.Hybrid.Razor14 ? tags.U("14") as IHtmlTag: tags.A("14").Href(Link.To(parameters: par.Set("Razor14", "true"))),
      " ",
      page is Custom.Hybrid.RazorPro ? tags.U("Pro") as IHtmlTag: tags.A("Pro").Href(Link.To(parameters: par.Set("Razor16", "true"))),
     ")");
  }
}
