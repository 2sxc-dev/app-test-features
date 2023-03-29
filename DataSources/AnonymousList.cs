using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System;
using System.Linq;
using ToSic.Eav.DataSource;
using ToSic.Eav.DataSource.VisualQuery;

public class AnonymousList : Custom.DataSource.DataSource15
{
  public AnonymousList(MyServices services) : base(services, "My.Magic")
  {
    ProvideOut(() => Enumerable.Range(1, AmountOfItems).Select(i => new {
        Id = i,
        guid = Guid.NewGuid(),
        Title = "Hello from AnonymousList",
        FavoriteNumber = FavoriteNumber,
      }).ToList()
    );
  }

  [Configuration(Fallback = 3)]
  public int AmountOfItems { get { return Configuration.GetThis(3); } }

  [Configuration(Fallback = 42)]
  public int FavoriteNumber { get { return Configuration.GetThis(42); } }
}
