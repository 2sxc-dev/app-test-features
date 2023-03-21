using ToSic.Eav.DataSources;
using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSources;
using ToSic.Eav.DataSources.Queries;

namespace MyCompany.DataSources {

	[VisualQuery(NameId = "42efa241-a404-4c69-a3ed-5860575319c4")]
  public class MagicDataSource : Custom.DataSources.DataSource15 {

    public MagicDataSource(MyServices services) : base(services, "My.Magic")
    {
      var newItem = new RawEntity() {
        Id = 27,
        Values = new Dictionary<string, object> {
          {"Title", "Hello from MagicDataSource"},
        }
      };
      ProvideOut(() => Enumerable.Repeat(newItem, AmountOfItems * 1).ToList());
    }

    [Configuration(Fallback = 3)]
    public int AmountOfItems {
      get { return Configuration.GetThis(3); }
    }
  }
}
