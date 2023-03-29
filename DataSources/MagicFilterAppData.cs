using System.Linq;
using ToSic.Eav.DataSource.VisualQuery;
using ToSic.Eav.DataSources;

public class MagicFilterAppData : Custom.DataSource.DataSource15
{
  public MagicFilterAppData(MyServices services) : base(services, "My.Magic")
  {    
    ProvideOut(() => {
      // Make sure we have an in
      var inStream = TryGetIn() ?? CreateDataSource<IAppRoot>().List;
      return inStream.Where(e => e.EntityId % 2 == 1);
    });
  }
}