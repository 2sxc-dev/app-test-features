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


[JsonFormatter(EntityFormat = EntityFormat.Light, Casing = Casing.Preserve)]
public class ChildController : ParentController
{

}

[JsonFormatter(EntityFormat = EntityFormat.Light, Casing = Casing.Camel)]
public class ParentController : GrandParentController
{

}

[AllowAnonymous]
[JsonFormatter(EntityFormat = EntityFormat.None, Casing = Casing.Preserve)]
public class GrandParentController : Custom.Hybrid.Api14
{
    [HttpGet]
    // [JsonFormatter(EntityFormat = EntityFormat.Light, Casing = Casing.Preserve)]
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

