using static AppCode.Show;

namespace AppCode
{
  public class Assert : Custom.Hybrid.CodeTyped
  {
    public static string AreEqual(bool value, bool expected) {
      return value == expected ? $"✅ ({BoolInfo(expected)})" : $"⚠️ ({BoolInfo(value)} != {BoolInfo(expected)})";
    }
  }
}
