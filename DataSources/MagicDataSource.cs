using ToSic.Eav.DataSources;
using ToSic.Eav.Data.Process;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSources.Queries;

namespace MyCompany.DataSources {

	[VisualQuery(
        NiceName = "My Magic",
        UiHint = "MagicDataSource",
        Icon = "token",
        Type = DataSourceType.Source, 
        GlobalName = "42efa241-a404-4c69-a3ed-5860575319c4",
	      // HelpLink = "https://github.com/2sic/2sxc/wiki/DotNet-DataSource-DnnSqlDataSource",
	      ExpectsDataOfType = "ff8e2c84-9f38-4eb7-8ea4-d34de6a1446a"
      )]
  public class MagicDataSource : Custom.Hybrid.DataSource15 {

    public MagicDataSource(MyServices services) : base(services, "My.Magic")
    {
      var newItem = new RawEntity() {
        Id = 27,
        Values = new Dictionary<string, object> {
          {"Title", "Hello from MagicDataSource"},
        }
      };
      ProvideOut(() => Enumerable.Repeat(newItem, AmountOfItems).ToList());
    }

    [Configuration]
    public int AmountOfItems {
      get { return Configuration.GetThis(3); }
    }

  }

}