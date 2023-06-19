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

[AllowAnonymous]
public class UseObsoleteCodeController : Custom.Hybrid.Api14
{
  [HttpGet]
  public string UseILogService()
  {
    var svc = GetService<ILogService>();
    return "this code used the ILogService - you should now have warnings in obsolete";
  }
}
