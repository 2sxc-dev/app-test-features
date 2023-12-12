public class ShowValues : Custom.Hybrid.Code14 
{
  public string NumberWithTypeInfo(object value) {
    return "" + value + " - Int: " + BoolMoji(value is int) + ", Float: " + BoolMoji(value is float) + ", Double: " + BoolMoji(value is double) + ", Decimal: " + BoolMoji(value is decimal);
  }

  public string BoolMoji(bool value) {
    return value ? "✅" : "❌";
  }
}
