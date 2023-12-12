using ToSic.Sxc.Data;
using ToSic.Razor.Blade;

public class CodeTests : Custom.Hybrid.CodeTyped
{
  public string SomeField = "This is a field";

  // Just a property to read
  public string Message {
    get {
      return "this is a message to you";
    }
  }

  public string MessageGetSet {get;set;}

  // A property to read/write
  public bool Activate { get; set; }

  // A method to call without parameters
  public string SayHello() {
    return "Hello from Hybrid Code 16 (Type: " + GetType() + "; Base: " + GetType().BaseType + ")";
  }

  // Method with parameters
  public string Bounce(string value) {
    return "Found the value '" + value + "' in the code.";
  }

  // Method with optional parameters
  public string BounceOptional(string value, string secondValue = null) {
    return "Found the value '" + value + "' in the code. " 
      + "Second value is '" + secondValue + "'";
  }

  // Method with overload
  public string Overload(string value) {
    return "Found the value '" + value + "' (" + value.GetType() + ") in the code. "
      + "(should be string)";
  }
  public string Overload(object value) {
    return "Found the value '" + value + "' (" + value.GetType() + ") in the code. "
      + "(should be object)";
  }
  public string Overload(bool value) {
    return "Found the value '" + value + "' (" + value.GetType() + ") in the code. "
      + "(should be object)";
  }

  public ITypedItem GetItem() {
    return AsItem(MyData);
  }

  public IHtmlTag Strong(string message) {
    return Kit.HtmlTags.Strong(message);
  }

}
