namespace AppCode
{
  public class ShowTestData : Custom.Hybrid.CodeTyped
  {
    /// <summary>
    /// Show a boolean value as an emoji
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    // TODO: make static, change all calls to static
    public string BoolMoji(bool value) {
      return value ? "✅" : "❌";
    }

    /// <summary>
    /// Show a boolean value as an emoji - but with non-aggressive (info) colors
    /// </summary>
    public static string BoolInfo(bool value) {
      return value ? "☑️" : "🟫";
    }
  }
}
