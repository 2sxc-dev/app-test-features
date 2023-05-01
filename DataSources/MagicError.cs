using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSource;
using ToSic.Eav.DataSource.VisualQuery;

// Test for scenarios with an Error DataSource
public class MagicError : Custom.DataSource.DataSource16
{
  public MagicError(MyServices services) : base(services, "My.Magic")
  {
    ProvideOut(() => {
      var newItem = new RawEntity() {
        Id = 27,
        // x = x
        Values = new Dictionary<string, object> {
          {"Title", "Hello from MagicDataSource"},
          {"FavoriteNumber", FavoriteNumber},
        }
      };
      return Enumerable.Repeat(newItem, AmountOfItems).ToList();
    });
  }

  [Configuration(Fallback = 3)]
  public int AmountOfItems { get { return Configuration.GetThis(3); } }

  [Configuration(Fallback = 42)]
  public int FavoriteNumber { get { return Configuration.GetThis(42); } }
}
