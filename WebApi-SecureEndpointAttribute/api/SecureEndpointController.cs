#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using System.Linq;
using ToSic.Sxc.Dnn.WebApi.Internal.SecureEndpoint;

[AllowAnonymous]
public class SecureEndpointController : Custom.Hybrid.ApiTyped
{
  public class Form1Data
  {
    public string Field1 { get; set; }
    public string Field2 { get; set; }
  }

  [HttpPost]
  [SecureEndpoint]
  public object SubmitForm(Form1Data data)
  {
    return data;
  }
}
