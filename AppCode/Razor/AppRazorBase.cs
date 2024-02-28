//
// For testing RazorTyped<TModel>
//
using AppCode.Data;
using ToSic.Sxc.Apps;

namespace AppCode.Razor
{
  public abstract class AppRazorBase: Custom.Hybrid.RazorTyped // <object, AppSettings, AppResources>
  {
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>();
    // public new IAppTyped<AppSettings, AppResources> App => _app ??= GetService<IAppTyped<AppSettings, AppResources>>(reuse: true);
    private IAppTyped<AppSettings, AppResources> _app;
  }

}
