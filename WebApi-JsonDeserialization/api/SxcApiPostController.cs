#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif


[AllowAnonymous]
[System.Obsolete]
public class SxcApiPostController : ToSic.SexyContent.WebApi.SxcApiController
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
