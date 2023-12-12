public class BasicDynamicCode12 : ToSic.Sxc.Code.DynamicCode12
{
  public string SayHello() {
    return "Hello from Dynamic Code 12 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
