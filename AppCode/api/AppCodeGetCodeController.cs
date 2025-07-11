
#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
// using DotNetNuke.Modules.UserDefinedTable.Components;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services; // Make it easier to use https://go.2sxc.org/services
using AppCode.Mails;

[AllowAnonymous]
public class AppCodeGetCodeController : Custom.Hybrid.ApiTyped
{
  [HttpGet]
  public string GetPath()
  {
    var temp = this as ToSic.Sxc.Code.Sys.IGetCodePath;
    return temp.CreateInstancePath;
  }

  [HttpGet]
  public string HelloFromSharedHelperRelative()
  {
    var code = GetCode("../WebApi/api/SharedHelperCode.cs");
    return code.GetHelloMessage();
  }

  [HttpGet]
  public string HelloFromSharedHelperAbsolute()
  {
    return "not implemented - absolute path currently only works in Razor, TODO";
    var code = GetCode("/WebApi/api/SharedHelperCode.cs");
    return code.GetHelloMessage();
  }

  [HttpGet]
  public string GenerateMailFromFullName()
  {
    throw new System.Exception("This experimental feature was removed in v20 since it doesn't make sense any more.");
    // var generator = GetService<IMailGenerator>(typeName: "AppCode.Mails.BasicMailGenerator");
    // return generator.Title("Hello Full Name");
  }

  [HttpGet]
  public string GenerateMailFromClassName()
  {
    throw new System.Exception("This experimental feature was removed in v20 since it doesn't make sense any more.");

    // var generator = GetService<IMailGenerator>(typeName: "BasicMailGenerator");
    // return generator.Title("Hello Class Name");
  }


}
