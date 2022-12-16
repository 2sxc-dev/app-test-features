using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ToSic.Eav.Apps;
using ToSic.Eav.Configuration;
using ToSic.Eav.Data;
using ToSic.Eav.Persistence.File;
using ToSic.Eav.Run;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;
using ToSic.Sxc.Services;
public class CmsServiceTest : Custom.Hybrid.Code14
{
  public IHtmlTag CmsServiceShow(string someHtmlValue)
  {
    var entity = TstDataEntity("someTextValue", someHtmlValue);
    var dynamicEntity = DynEntity(entity);
    var dynamicField = dynamicEntity.Field("Body");
    var imgService = GetService<Lazy<IImageService>>();
    var valueConverter = GetService<Lazy<IValueConverter>>();
    var cmsService = new ToSic.Sxc.Services.CmsService.CmsService(imgService, valueConverter);
    return cmsService.Show(dynamicField);
  }

  private IEntity TstDataEntity(string text = "", string html = "")
  {
    var appStates = GetService<IAppStates>();
    var app = appStates.Get(App.AppId);
    var contentType = app.GetContentType("CmsServiceTest");
    if (contentType == null)
      throw new Exception("CmsServiceTest content type not found");
    var values = new Dictionary<string, object>() { { "Title", text }, { "Body", html } };
    return new Entity(App.AppId, 0, contentType, values, "Title");
  }
  private DynamicEntity DynEntity(IEntity entity = null)
  {
    var dynamicEntityDependencies = GetService<DynamicEntityDependencies>();
    return new DynamicEntity(entity, dynamicEntityDependencies);
  }
}
