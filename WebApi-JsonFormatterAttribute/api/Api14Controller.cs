#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using System.Linq;


[AllowAnonymous]
public class Api14Controller : Custom.Hybrid.Api14
{
  [HttpGet]
  public object GetEntity() => App.Data.List.First();

  [HttpGet]
  public object GetEntities() => App.Data.List.Take(10);
}
