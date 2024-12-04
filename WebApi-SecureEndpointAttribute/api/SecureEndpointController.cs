#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;

[AllowAnonymous]
public class SecureEndpointController : Custom.Hybrid.ApiTyped
{
  public class Form1Data
  {
    public string Field1 { get; set; }
    public string Field2 { get; set; }
  }

  public class Form2Data
  {
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public int P4 { get; set; }
  }

  [HttpPost]
  [SecureEndpoint]
  public object SubmitForm(Form1Data data)
  {
    return data;
  }

  [HttpPost]
  [SecureEndpoint]
  public object SubmitForm2(int q1, Form2Data data, string q2, string q3 = "default")
  {
    return new { q1, data, q2, q3 };
  }

  [HttpPost]
  [SecureEndpoint]
  public object SubmitForm3(dynamic data)
  {
    return data;
  }
}
