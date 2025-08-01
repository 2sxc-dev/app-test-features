// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TestGetValuesModel.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TestGetValuesModel
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpCustomModelsGenerator
// App/Edition: App Test Features/
// User:        2sichost
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ToSic.Sxc.Adam;
using ToSic.Sxc.Cms.Data;

namespace AppCode.Data
{
  // This is a generated custom model class for TestGetValues 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TestGetValues custom model. <br/>
  /// Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// This is a lightweight model that inherits from CustomModel. <br/>
  /// For properties, use the strongly-typed access such as `.Bool`. <br/>
  /// For advanced features, consider using the full CustomItem instead.
  /// </summary>
  public partial class TestGetValuesModel: AutoGenerated.ZAutoGenTestGetValuesModel
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TestGetValuesModel in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenTestGetValuesModel: Custom.Data.CustomModel
  {
    /// <summary>
    /// Bool as bool. <br/>
    /// To get nullable use .Get("Bool") as bool?;
    /// </summary>
    public bool Bool => _item.Bool("Bool");

    /// <summary>
    /// BoolNullable as bool. <br/>
    /// To get nullable use .Get("BoolNullable") as bool?;
    /// </summary>
    public bool BoolNullable => _item.Bool("BoolNullable");

    /// <summary>
    /// Child as single item of TestGetValues.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type TestGetValues was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public TestGetValues Child => _child ??= _item.Child<TestGetValues>("Child");
    private TestGetValues _child;

    /// <summary>
    /// Children as list of TestGetValues.
    /// </summary>
    /// <remarks>
    /// Generated to return child-list child because field settings had Multi-Value=true. The type TestGetValues was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// An IEnumerable of specified type, but can be empty.
    /// </returns>
    public IEnumerable<TestGetValues> Children => _children ??= _item.Children<TestGetValues>("Children");
    private IEnumerable<TestGetValues> _children;

    /// <summary>
    /// Date as DateTime.
    /// </summary>
    public DateTime Date => _item.DateTime("Date");

    /// <summary>
    /// DateAndTime as DateTime.
    /// </summary>
    public DateTime DateAndTime => _item.DateTime("DateAndTime");

    /// <summary>
    /// File as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("File")
    /// </summary>
    public string File => _item.Url("File");

    /// <summary>
    /// Get the file object for File - or null if it's empty or not referencing a file.
    /// </summary>

    [JsonIgnore]
    public IFile FileFile => _item.File("File");

    /// <summary>
    /// Get the folder object for File.
    /// </summary>

    [JsonIgnore]
    public IFolder FileFolder => _item.Folder("File");

    /// <summary>
    /// GpsData as GPS Coordinates object with Latitude and Longitude.
    /// </summary>
    public GpsCoordinates GpsData => _item.Gps("GpsData");

    /// <summary>
    /// NameId as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("NameId", scrubHtml: true) etc.
    /// </summary>
    public string NameId => _item.String("NameId", fallback: "");

    /// <summary>
    /// Number as int. <br/>
    /// To get other types use methods such as .Decimal("Number")
    /// </summary>
    public int Number => _item.Int("Number");

    /// <summary>
    /// NumberFloat as decimal. <br/>
    /// To get other types use methods such as .Int("NumberFloat")
    /// </summary>
    public decimal NumberFloat => _item.Decimal("NumberFloat");

    /// <summary>
    /// String as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("String", scrubHtml: true) etc.
    /// </summary>
    public string String => _item.String("String", fallback: "");

    /// <summary>
    /// Text as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Text", scrubHtml: true) etc.
    /// </summary>
    public string Text => _item.String("Text", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public string Title => _item.String("Title", fallback: "");

    /// <summary>
    /// Wysiwyg as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Wysiwyg", scrubHtml: true) etc.
    /// </summary>
    public string Wysiwyg => _item.String("Wysiwyg", fallback: "");
  }
}