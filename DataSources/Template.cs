// Template Dynamic DataSource - learn about this on https://r.2sxc.org/DsCustom
using System;
using System.Collections.Generic;
using System.Linq;
using ToSic.Eav.DataSource;

// Class name must match file name, and must extend Custom.DataSource.DataSource16
public class Template : Custom.DataSource.DataSource16
{
  // Constructor: must forward MyServices to the base class
  public Template(MyServices services) : base(services)
  {
    // ProvideOut will be called when the data is requested
    // in this example it will return a list on the Default stream
    ProvideOut(() => {
      // Dummy list of numbers using the Configuration "AmountOfItems"
      var listOfNumbers = Enumerable.Range(1, AmountOfItems);

      // Create a list of anonymous objects with some data
      return listOfNumbers.Select(i => new {
        Id = i,
        guid = Guid.NewGuid(),
        Title = Greeting
      }).ToList();
    });
  }

  // Configuration ensures that there is a config with the name "Greetings"
  [Configuration(Fallback = "Hello from Template DataSource")]
  public string Greeting { get { return Configuration.GetThis(); }}

  // Another configuration. Since it's an int,
  // we must provide a fallback in the GetThis(3) in case the incoming config is not a number
  [Configuration(Fallback = 10)]
  public int AmountOfItems { get { return Configuration.GetThis(3); } }
}
