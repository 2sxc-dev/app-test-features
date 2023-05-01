using System.Collections.Generic;
using System.Linq;

public class MagicFilterRawAndEntity : Custom.DataSource.DataSource16
{

  public MagicFilterRawAndEntity(MyServices services) : base(services, "My.Magic")
  {    
    ProvideOut(() => {
      // Make sure we have an in
      var inStream = TryGetIn();
      if (inStream == null) return Error.TryGetInFailed();
      return inStream.Where(e => e.EntityId % 2 == 1);
    });
  }
}