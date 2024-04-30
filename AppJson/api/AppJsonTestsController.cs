#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif

[AllowAnonymous]
public class AppJsonTestsController : Custom.Hybrid.Api14
{
    [HttpGet]
    public string Available()
    {
        string available = null;
        available ??= "available";
        return available;
    }
}
