public class LogCode14 : Custom.Hybrid.Code14
{
  public string SayHello() {
    // Try to access the Kit
    var x = Kit.Convert.ToInt("27.4") + 2;

    // this must fail
    // var x = Convert.ToInt("27.4") + 2;
    return "Hello from shared functions! - got " + x;
  }
  public string LogType()
  {
    return Log.GetType().ToString();
  }
  public string BaseType()
  {
    return this.GetType().BaseType.ToString();
  }
  public string CodeType()
  {
    return this.GetType().ToString();
  }
  public bool SimpleTest()
  {
    return CreateInstance("TestLog.cs").SimpleTest(Log);
  }
  public string DumpLog()
  {
    return CreateInstance("TestLog.cs").Dump(Log);
  }
}
