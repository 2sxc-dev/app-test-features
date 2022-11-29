public class LogDynamicCode : ToSic.Sxc.Dnn.DynamicCode
{
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
