using ToSic.Eav.DataSources;
using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSources;
using ToSic.Eav.DataSources.Queries;

namespace MyCompany.DataSources {

  public class MagicFilterRawAndEntity : Custom.DataSources.DataSource15
  {

    public MagicFilterRawAndEntity(MyServices services) : base(services, "My.Magic")
    {    
      // x = 27;
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
