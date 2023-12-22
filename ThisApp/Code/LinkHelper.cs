using System;

namespace ThisApp.Code
{
  public class LinkHelper : Custom.Hybrid.Code14
  {
    public string SayHello()
    {
      // Try to access the Kit
      var x = Kit.Convert.ToInt("27.4") + 2;

      // this must fail
      // var x = Convert.ToInt("27.4") + 2;
      return "Hello from shared functions! - got " + x;
    }
  }
}

