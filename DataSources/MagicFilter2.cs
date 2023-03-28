using System.Linq;

public class MagicFilter2 : Custom.DataSource.DataSource15
{
  public MagicFilter2(MyServices services) : base(services, "My.Magic")
  {    
    // x = 27;
    ProvideOut(() => {
      // Make sure we have an in
      var inStream = TryGetIn();
      if (inStream == null) return Error.TryGetInFailed();
      return inStream.Where(e => e.EntityId % 2 == 1);
    });
  }
}
