#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif


[AllowAnonymous]
public class Api12PostController : Custom.Hybrid.Api12
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
