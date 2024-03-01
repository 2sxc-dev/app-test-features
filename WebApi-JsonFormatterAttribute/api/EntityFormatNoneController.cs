#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;
using System.Linq;


[AllowAnonymous]
[JsonFormatter(EntityFormat = EntityFormat.None)]
public class EntityFormatNoneController : Custom.Hybrid.Api14
{
  [HttpGet]
  public object GetEntity() => App.Data.List.First();

  [HttpGet]
  public object GetEntities() => App.Data.List.Take(10);
}
