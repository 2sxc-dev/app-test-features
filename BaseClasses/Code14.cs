using ToSic.Sxc.Services;

public class Code14 : Custom.Code14<dynamic, Kit14> {
  public string SayHello() {
    // Try to access the Kit
    var x = Kit.Convert.ToInt("27.4") + 2;
    return "Hello from shared functions! - got " + x;
  }
}
