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
using Dynlist = System.Collections.Generic.IEnumerable<dynamic>;


[AllowAnonymous]
public class MethodController : Custom.Hybrid.Api15
{
    [HttpGet]
    [JsonFormatter(EntityFormat = EntityFormat.Light, Casing = Casing.Preserve)]
    public object GetEntity()
    {
        return (App.Data.List.First());
    }

    [HttpGet]
    [JsonFormatter(EntityFormat = EntityFormat.None, Casing = Casing.Camel)]
    public object GetEntities()
    {
        return App.Data.List;
    }
}
