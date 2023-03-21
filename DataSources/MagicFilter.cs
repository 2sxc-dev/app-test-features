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
        Icon = "star"
        // Type = DataSourceType.App,
        // GlobalName = "MagicFilter" 
        ,
        NameId = "48c82e56-2db6-46f2-bc54-eeea17a8b164"
	      // ConfigurationType = "MagicDataSourceConfiguration"
      )]
  public class MagicFilter : Custom.DataSources.DataSource15
  {

    public MagicFilter(MyServices services) : base(services, "My.Magic")
    {    
      ProvideOut(() => {
        // Make sure we have an in
        var inStream = TryGetIn();
        if (inStream == null) return Error.TryGetInFailed();
        return inStream.Where(e => e.EntityId % 2 == 1);
      });
    }

    // [Configuration(Fallback = 3)]
    // public int AmountOfItems {
    //   get { return Configuration.GetThis(3); }
    // }
  }
}
