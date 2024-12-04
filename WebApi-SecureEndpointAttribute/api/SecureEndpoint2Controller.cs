#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using ToSic.Sxc.WebApi;

[AllowAnonymous]
[SecureEndpoint]
public class SecureEndpoint2Controller : Custom.Hybrid.ApiTyped
{
  public class Form21Data
  {
    public string Field1 { get; set; }
    public string Field2 { get; set; }
  }

  public class Form22Data
  {
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public int P4 { get; set; }
  }

  [HttpPost]
  public object SubmitForm(Form21Data data)
  {
    return data;
  }

  [HttpPost]
  public object SubmitForm2(int q1, Form22Data data, string q2, string q3 = "default")
  {
    return new { q1, data, q2, q3 };
  }
}
