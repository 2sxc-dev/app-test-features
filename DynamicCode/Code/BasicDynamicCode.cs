public class BasicDynamicCode : ToSic.Sxc.Code.DynamicCode
{
  public string SayHello() {
    return "Hello from Dynamic Code (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }
}
