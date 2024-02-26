//
// For testing RazorTyped<TModel>
//
namespace AppCode.Razor
{
  public class Model3Props
  {
    public string Name { get; set; }
    public int Number { get; set; }
    public Something Something { get; set; }
  }

  public class Something
  {
    public string Name { get; set; }
  }
}
