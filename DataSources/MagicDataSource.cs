using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSource;
using ToSic.Eav.DataSource.VisualQuery;

[VisualQuery(NameId = "42efa241-a404-4c69-a3ed-5860575319c4")]
public class MagicDataSource : Custom.DataSource.DataSource16
{
  public MagicDataSource(MyServices services) : base(services, "My.Magic")
  {
    ProvideOut(() => {
      var newItem = new RawEntity() {
        Id = 27,
        Values = new Dictionary<string, object> {
          {"Title", "Hello from MagicDataSource"},
          {"FavoriteNumber", FavoriteNumber},
        }
      };
      return Enumerable.Repeat(newItem, AmountOfItems * 1).ToList();
    });
  }

  [Configuration(Fallback = 3)]
  public int AmountOfItems { get { return Configuration.GetThis(3); } }

  [Configuration(Fallback = 42)]
  public int FavoriteNumber { get { return Configuration.GetThis(42); } }
}
