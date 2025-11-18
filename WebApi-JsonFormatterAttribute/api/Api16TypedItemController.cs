#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
#endif
using System.Linq;
using ToSic.Sxc.Data;
using System.Collections.Generic;


[AllowAnonymous]
public class Api16TypedItemController : Custom.Hybrid.ApiTyped
{
  [HttpGet]
  public object GetEntity()
  {
    var item = AsItem(App.Data.List.First(i => i.GetBestTitle() == "App Test Features"));
    Log.Add($"returning item id {item.Id} - Description: {item.String("Description")}");

    // var list = new List<ITypedItem> { item };
    // var json = Kit.Json.ToJson(item as object);
    return item;
  }

  [HttpGet]
  public object GetEntities() => AsItems(App.Data.List.Take(5));
}
