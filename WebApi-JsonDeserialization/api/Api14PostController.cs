#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif


[AllowAnonymous]
public class Api14PostController : Custom.Hybrid.Api14
{
  public class PostTest
  {
    public int IAmNull { get; set; }
  }

  [HttpPost]
  public object UpdatePostTest([FromBody] PostTest postTest)
  {
    return postTest;
  }
}
