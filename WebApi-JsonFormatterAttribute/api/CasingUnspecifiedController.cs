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
[JsonFormatter(Casing = Casing.Unspecified)]
public class CasingUnspecifiedController : Custom.Hybrid.Api14
{
  [HttpGet]
  public object GetEntity() => App.Data.List.First();

  [HttpGet]
  public object GetEntities() => App.Data.List.Take(10);
}
