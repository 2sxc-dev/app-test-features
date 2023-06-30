public class CodePro : Custom.Hybrid.CodePro
{
  public string SayHello() {
    return "Hello from Hybrid Code 16 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
