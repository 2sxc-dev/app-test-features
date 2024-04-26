
#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services;

[AllowAnonymous]
public class My10Controller : Custom.Hybrid.ApiTyped
{
    [HttpGet]
    public string Hello()
    {
        return "Hello from the api controller from AppCode in edition: 'live'";
    }
}
