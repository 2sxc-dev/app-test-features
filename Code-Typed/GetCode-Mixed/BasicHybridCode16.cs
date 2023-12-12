public class BasicHybridCode16 : Custom.Hybrid.CodeTyped
{
  public string SayHello() {
    return "Hello from Hybrid Code 16 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
