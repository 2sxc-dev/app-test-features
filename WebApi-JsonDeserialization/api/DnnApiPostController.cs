#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif


[AllowAnonymous]
[System.Obsolete]
public class DnnApiPostController : ToSic.Sxc.Dnn.ApiController
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
