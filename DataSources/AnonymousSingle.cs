using System;
using ToSic.Eav.DataSource;

public class AnonymousSingle : Custom.DataSource.DataSource15 {

  public AnonymousSingle(MyServices services) : base(services, "My.Magic")
  {
    ProvideOut(() => new {
        Id = 27,
        guid = Guid.NewGuid(),
        Title = "Hello from AnonymousSingle",
        FavoriteNumber = Configuration.Get("FavoriteNumber", fallback: 7), // FavoriteNumber,
      });
  }

  // [Configuration(Fallback = 42)]
  // public int FavoriteNumber { get { return Configuration.GetThis(42); } }
}
