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
public class Test7Controller : Custom.Hybrid.Api15
{
    [HttpGet]
    [JsonFormatter(AutoConvertEntity = true, Casing = Casing.PascalCase)]
    public object GetEntity()
    {
        return (App.Data.List.First());
    }

    [HttpGet]
    [JsonFormatter(AutoConvertEntity = false, Casing = Casing.CamelCase)]
    public object GetEntities()
    {
        return App.Data.List;
    }

    [HttpGet]
    public object Test3()
    {
        var entity = App.Data.List.First();
        return new EntityWrapper(entity, null);
    }

    [HttpGet]
    public object Test4()
    {
        return AsList(App.Data).Select(d => new EntityWrapper(AsEntity(d), null));
    }
}
