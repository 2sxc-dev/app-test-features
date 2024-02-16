using AppCode;

public class Helpers : Custom.Hybrid.CodeTyped
{
  public string SayHello()
  {
    var d1 = new DepLibrary1.DepClass();
    return d1.MyProperty;
  }
}
