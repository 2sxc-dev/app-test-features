using ToSic.Eav.DataSources;
using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.Data.Raw;
using ToSic.Eav.DataSources;
using ToSic.Eav.DataSources.Queries;

namespace MyCompany.DataSources {

	[VisualQuery(
        // NiceName = "My Magic",
        // UiHint = "MagicDataSource in this app",
        Icon = "star",
        Type = DataSourceType.App,
        NameId = "42efa241-a404-4c69-a3ed-5860575319c4",
	      // HelpLink = "https://github.com/2sic/2sxc/wiki/DotNet-DataSource-DnnSqlDataSource",
	      ConfigurationType = "MagicDataSourceConfiguration" // "ff8e2c84-9f38-4eb7-8ea4-d34de6a1446a"
      )]
  public class MagicDataSource : Custom.DataSources.DataSource15 {

    public MagicDataSource(MyServices services) : base(services, "My.Magic")
    {
      var newItem = new RawEntity() {
        Id = 27,
        Values = new Dictionary<string, object> {
          {"Title", "Hello from MagicDataSource"},
        }
      };
      ProvideOutRaw(() => Enumerable.Repeat(newItem, AmountOfItems * 1).ToList());
    }

    [Configuration(Fallback = 3)]
    public int AmountOfItems {
      get { return Configuration.GetThis(3); }
    }
  }
}
