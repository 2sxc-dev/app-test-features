#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services; // Make it easier to use https://r.2sxc.org/services

[AllowAnonymous]
public class OqtaneApiController : Custom.Oqtane.Api12
{

  [HttpGet]
  public dynamic ApiTypeInfo()
  {
    var test = CreateInstance("../TestLog.cs");
    return new {
      codeType = this.GetType().ToString(),
      baseType = this.GetType().BaseType.ToString(),
      logType = Log.GetType().ToString(),
      simpleTest = test.SimpleTest(Log),
      dumpLog = test.DumpLog(Log)
    };
  }
}
