// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// All the classes are partial, so you can extend them in a separate file.

// Generator:   WebApiGenerator v17.05.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-22 15:02:29Z

using AppCode.Data;
using ToSic.Sxc.Apps;

namespace AppCode.Api
{
  /// <summary>
  /// Base Class for Services which have a typed App.
  /// </summary>
  public abstract partial class ControllerBase: Custom.Hybrid.ApiTyped
  {

    /// <summary>
    /// Typed App with typed Settings & Resources
    /// </summary>
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>();
    private IAppTyped<AppSettings, AppResources> _app;
  }
}
