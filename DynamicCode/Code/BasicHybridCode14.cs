public class BasicHybridCode14 : Custom.Hybrid.Code14
{
  public string SayHello() {
    return "Hello from Hybrid Code 14 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
