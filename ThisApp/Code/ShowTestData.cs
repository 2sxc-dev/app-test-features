using System;

namespace ThisApp.Code
{
  public class ShowTestData : Custom.Hybrid.CodeTyped
  {
    /// <summary>
    /// Show a boolean value as an emoji
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// 
    public string BoolMoji(bool value) {
      return value ? "✅" : "❌";
    }
  }
}
