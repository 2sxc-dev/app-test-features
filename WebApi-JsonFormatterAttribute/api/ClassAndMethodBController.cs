#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;
using System.Linq;


[AllowAnonymous]
[JsonFormatter(EntityFormat = EntityFormat.None, Casing = Casing.Preserve)]
public class ClassAndMethodBController : Custom.Hybrid.Api14
{
  [HttpGet]
  [JsonFormatter(EntityFormat = EntityFormat.Light)]
  public object GetEntity() => App.Data.List.First();

  [HttpGet]
  [JsonFormatter(Casing = Casing.Camel)]
  public object GetEntities() => App.Data.List.Take(10);
}
