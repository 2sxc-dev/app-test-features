#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using ToSic.Eav.Data;
using ToSic.Sxc.WebApi;
using ToSic.Sxc.Services; // Make it easier to use https://r.2sxc.org/services
using System.Linq;
using System.Collections;
using System.Collections.Generic;


[AllowAnonymous]
[JsonFormatter(Casing = Casing.Preserve)]
public class Api16CasingPreserveController : Custom.Hybrid.ApiTyped
{
    [HttpGet]
    public object GetEntity()
    {
        return (App.Data.List.First());
    }

    [HttpGet]
    public object GetEntities()
    {
        return App.Data.List;
    }
}
