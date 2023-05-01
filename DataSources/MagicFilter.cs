using System.Linq;
using ToSic.Eav.DataSource.VisualQuery;

[VisualQuery(NameId = "48c82e56-2db6-46f2-bc54-eeea17a8b164")]
public class MagicFilter : Custom.DataSource.DataSource16
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
}