using System;

namespace MyApp.Code
{
  public class DemoService : Custom.Hybrid.Code14
  {
    public string SayHello()
    {
      return new LinkHelper().SayHello();
    }
  }
}
