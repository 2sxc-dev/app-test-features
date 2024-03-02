#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using System.Linq;
using AppCode.Data;


[AllowAnonymous]
public class Api16CustomItemController : Custom.Hybrid.ApiTyped
{
  [HttpGet]
  public object GetEntity() => App.Data.GetAll<TestGetValues>().First();

  [HttpGet]
  public object GetEntities() => App.Data.GetAll<TestGetValues>().Take(5);
}
