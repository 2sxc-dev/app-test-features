#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;
using System.Linq;


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
  public object GetEntity() => App.Data.List.First();

  [HttpGet]
  [JsonFormatter(EntityFormat = EntityFormat.None, Casing = Casing.Camel)]
  public object GetEntities() => App.Data.List.Take(10);
}

