#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services; // Make it easier to use https://go.2sxc.org/services
using AppCode;

[AllowAnonymous]      // define that all commands can be accessed without a login
// Inherit from Custom.Hybrid.ApiTyped to get features like App, MyContext, Data etc.
// see https://docs.2sxc.org/web-api/custom/index.html
// Learn more on https://go.2sxc.org/cs-typed
public class My4Controller : Custom.Hybrid.ApiTyped
{
    [HttpGet]        // [HttpGet] says we're listening to GET requests
    public string Hello()
    {
        var firstClass = new FirstClass();
        return $"Hello from the controller relaying on AppCode ({firstClass.SecondClass.MyProperty}).";
    }
}
