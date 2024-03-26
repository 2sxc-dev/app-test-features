
#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif
using ToSic.Sxc.Services; // Make it easier to use https://go.2sxc.org/services

namespace AppCode.Api
{
  [AllowAnonymous]
  public class My2Controller : AppCode.Api.ControllerBase
  {
      [HttpGet]        // [HttpGet] says we're listening to GET requests
      public string Hello()
      {
          return "Hello2 from AppCode.";
      }
  }

}