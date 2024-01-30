#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using System.Linq;


[AllowAnonymous]
public class Api16TypedItemController : Custom.Hybrid.ApiTyped
{
  [HttpGet]
  public object GetEntity() => AsItem(App.Data.List.First());

  [HttpGet]
  public object GetEntities() => AsItems(App.Data.List.Take(5));
}
