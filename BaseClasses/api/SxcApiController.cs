using System.Web.Http;
using DotNetNuke.Web.Api;
using ToSic.Sxc.Services; // Make it easier to use https://r.2sxc.org/services

[AllowAnonymous]
public class SxcApiController : ToSic.SexyContent.WebApi.SxcApiController
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
