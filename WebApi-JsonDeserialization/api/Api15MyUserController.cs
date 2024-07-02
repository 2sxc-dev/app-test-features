#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using ToSic.Sxc.Context;

#endif
using ToSic.Sxc.WebApi;

[AllowAnonymous]
[JsonFormatter(Casing = Casing.Camel)]
public class Api15MyUserController : Custom.Hybrid.ApiTyped
{
  [HttpPost]
  public ICmsUser UpdatePostTest() => MyUser;
}
