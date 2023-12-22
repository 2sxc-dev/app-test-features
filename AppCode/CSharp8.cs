namespace ThisApp.Code
{


  public class CSharp8 {
    public string Name => "Hello";

    public string Name2 {
      get { return  "Hello"; }
    }

    public (int x, int y) GetPoint() => (1, 2);

    public string NullCoalescingAssigment(string? value) {
      value ??= "Hello";
      return value;
    }
  }

}