// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "WithGPSModel.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class WithGPSModel
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpCustomModelsGenerator
// App/Edition: App Test Features/
// User:        2sichost
using ToSic.Sxc.Cms.Data;

namespace AppCode.Data
{
  // This is a generated custom model class for WithGPS 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// WithGPS custom model. <br/>
  /// Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// This is a lightweight model that inherits from CustomModel. <br/>
  /// For properties, use the strongly-typed access such as `.GPS`. <br/>
  /// For advanced features, consider using the full CustomItem instead.
  /// </summary>
  public partial class WithGPSModel: AutoGenerated.ZAutoGenWithGPSModel
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.WithGPSModel in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenWithGPSModel: Custom.Data.CustomModel
  {
    /// <summary>
    /// GPS as GPS Coordinates object with Latitude and Longitude.
    /// </summary>
    public GpsCoordinates GPS => _item.Gps("GPS");

    /// <summary>
    /// GPSLat as int. <br/>
    /// To get other types use methods such as .Decimal("GPSLat")
    /// </summary>
    public int GPSLat => _item.Int("GPSLat");

    /// <summary>
    /// GPSLong as int. <br/>
    /// To get other types use methods such as .Decimal("GPSLong")
    /// </summary>
    public int GPSLong => _item.Int("GPSLong");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public string Title => _item.String("Title", fallback: "");
  }
}