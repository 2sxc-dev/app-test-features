// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FieldsStringWysiwygInnerContent.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FieldsStringWysiwygInnerContent
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.04.01
// App/Edition: App Test Features/
// User:        2sichost
// When:        2024-03-18 16:01:34Z
using System.Collections.Generic;
using ToSic.Sxc.Data;

namespace AppCode.Data
{
  // This is a generated class for FieldsStringWysiwygInnerContent 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FieldsStringWysiwygInnerContent data. <br/>
  /// Generated 2024-03-18 16:01:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.InnerContent`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FieldsStringWysiwygInnerContent: AutoGenerated.ZagFieldsStringWysiwygInnerContent
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FieldsStringWysiwygInnerContent in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFieldsStringWysiwygInnerContent: Custom.Data.CustomItem
  {
    /// <summary>
    /// InnerContent as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("InnerContent", scrubHtml: true) etc.
    /// </summary>
    public string InnerContent => _item.String("InnerContent", fallback: "");

    /// <summary>
    /// InnerContentData as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem InnerContentData => _innerContentData ??= _item.Child("InnerContentData");
    private ITypedItem _innerContentData;

    /// <summary>
    /// NoInnerContent as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("NoInnerContent", scrubHtml: true) etc.
    /// </summary>
    public string NoInnerContent => _item.String("NoInnerContent", fallback: "");
  }
}