
#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using AppCode.Mails;
using DotNetNuke.Modules.UserDefinedTable.Components;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services; // Make it easier to use https://go.2sxc.org/services

[AllowAnonymous]
public class AppCodeGetCodeController : Custom.Hybrid.ApiTyped
{
  [HttpGet]
  public string GetPath()
  {
    var temp = this as ToSic.Sxc.Code.Internal.IGetCodePath;
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
    var generator = GetService<IMailGenerator>(typeName: "AppCode.Mails.BasicMailGenerator");
    return generator.Title("Hello Full Name");
  }

  [HttpGet]
  public string GenerateMailFromClassName()
  {
    var generator = GetService<IMailGenerator>(typeName: "BasicMailGenerator");
    return generator.Title("Hello Class Name");
  }


}
