// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AutoGenTests.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AutoGenTests
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.03.00
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-02 17:54:06Z
using System.Collections.Generic;
using ToSic.Sxc.Cms.Data;
using ToSic.Sxc.Data;

namespace AppCode.Data
{
  // This is a generated class for AutoGenTests
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AutoGenTests data. <br/>
  /// Generated 2024-03-02 17:54:06Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.EntityNotConfigured`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class AutoGenTests: AutoGenerated.ZagAutoGenTests
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for AutoGenTests in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagAutoGenTests: Custom.Data.CustomItem
  {
    /// <summary>
    /// EntityNotConfigured as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem EntityNotConfigured => _entityNotConfigured ??= _item.Child("EntityNotConfigured");
    private ITypedItem _entityNotConfigured;

    /// <summary>
    /// EntityOfType as single item of Quotes.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Quotes was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Quotes EntityOfType => _entityOfType ??= _item.Child<Quotes>("EntityOfType");
    private Quotes _entityOfType;

    /// <summary>
    /// Gps as GPS Coordinates object with Latitude and Longitude.
    /// </summary>
    public GpsCoordinates Gps => _item.Gps("Gps");

    /// <summary>
    /// NumberDecimal as decimal. <br/>
    /// To get other types use methods such as .Int("NumberDecimal")
    /// </summary>
    public decimal NumberDecimal => _item.Decimal("NumberDecimal");

    /// <summary>
    /// NumberInt as int. <br/>
    /// To get other types use methods such as .Decimal("NumberInt")
    /// </summary>
    public int NumberInt => _item.Int("NumberInt");

    /// <summary>
    /// NumberIntNeverConfigured as int. <br/>
    /// To get other types use methods such as .Decimal("NumberIntNeverConfigured")
    /// </summary>
    public int NumberIntNeverConfigured => _item.Int("NumberIntNeverConfigured");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}