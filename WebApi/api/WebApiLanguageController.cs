#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using System.Linq;

[AllowAnonymous]      // define that all commands can be accessed without a login
// Inherit from Custom.Hybrid.Api14 to get features like App, CmsContext, Data etc.
// see https://docs.2sxc.org/web-api/custom/index.html
public class WebApiLanguageController : Custom.Hybrid.ApiTyped
{
    [HttpGet]        // [HttpGet] says we're listening to GET requests
    public string Hello()
    {
      // Find out the current thread culture language
      var lang = System.Threading.Thread.CurrentThread.CurrentCulture.Name;

      // Get data of the MultiLanguageTests
      var item = AsItem(App.Data["MultiLanguageTests"].List.FirstOrDefault());


      return "Hello from WebApiLanguageController API controller in /api - current language: "
        + lang
        + " - item title: " + item?.Title;
    }
}
