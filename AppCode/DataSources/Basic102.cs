
namespace App.DataSources
{
  public class Basic102 : Custom.DataSource.DataSource16
  {
    public Basic102(MyServices services) : base(services)
    {
      ProvideOut(() => new
      {
        Title = "Hello from Basic102 with namespace",
        FavoriteNumber = 2742,
      });
    }
  }
}

