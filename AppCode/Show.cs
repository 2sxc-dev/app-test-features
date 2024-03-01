namespace AppCode
{
  public class Show : Custom.Hybrid.CodeTyped
  {
    /// <summary>
    /// Show a boolean value as an emoji
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string Bool(bool value) {
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
