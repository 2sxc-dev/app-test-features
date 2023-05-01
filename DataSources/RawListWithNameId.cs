using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSource;
using ToSic.Eav.DataSource.VisualQuery;

[VisualQuery(NameId = "8957f3ac-dc17-47da-90d3-e861be801878")]
public class RawListWithNameId : Custom.DataSource.DataSource16 {

  public RawListWithNameId(MyServices services) : base(services, "My.Magic")
  {
    ProvideOut(() => {
      var newItem = new RawEntity() {
        Id = 27,
        Values = new Dictionary<string, object> {
          {"Title", "Hello from RawListWithNameId"},
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
