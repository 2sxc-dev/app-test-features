#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;


[AllowAnonymous]
[JsonFormatter(Casing = Casing.Camel)]
public class Api15PostController : Custom.Hybrid.ApiTyped
{
  public class PostTest
  {
    public int? IAmNull { get; set; }
  }

  [HttpPost]
  public object UpdatePostTest([FromBody] PostTest postTest)
  {
    return postTest;
  }
}
