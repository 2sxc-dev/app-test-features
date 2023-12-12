public class BasicHybridCode12 : Custom.Hybrid.Code12
{
  public string SayHello() {
    return "Hello from Hybrid Code 12 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
