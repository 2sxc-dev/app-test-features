using ToSic.Razor.Blade;
using ToSic.Sxc.Services;
using System.Web;
using System.Linq;
using System.IO;

public class TestTreeHelpers: Custom.Hybrid.Code12
{
  public string GetFullPath(string filePath) {
    #if NETCOREAPP
      // This is the Oqtane implementation - cannot use Server.MapPath
      var hostingEnv = GetService<Microsoft.AspNetCore.Hosting.IHostingEnvironment>();
      var pathWithTrimmedFirstSlash = filePath.TrimStart(new [] { '/', '\\' });
      return System.IO.Path.Combine(hostingEnv.ContentRootPath, pathWithTrimmedFirstSlash);
    #else
      return HttpContext.Current.Server.MapPath(filePath);
    #endif
  }

  public string[] SubFolderNames(string filePath) {
    var fullPath = filePath.Contains(":") ? filePath : GetFullPath(filePath);
    var pathOnly = Path.GetDirectoryName(fullPath);
    var subDirectories = Directory.GetDirectories(pathOnly);
    return subDirectories
      .Where(sd => {
        var name = Path.GetFileName(sd);
        return !name.StartsWith(".") && !name.StartsWith("_") && name != "App_Data" && name != "api";
      })
      .Select(sd => sd.Substring(App.PhysicalPath.Length + 1))
      .ToArray();
  }

  public string[] FileNames(string filePath) {
    var fullPath = filePath.Contains(":") ? filePath : GetFullPath(filePath);
    var pathOnly = Path.GetDirectoryName(fullPath);
    var files = Directory.GetFiles(pathOnly);
    return files
      .Where(f => {
        var name = Path.GetFileName(f);
        return name.EndsWith(".cshtml")
          // filter out __ prefixed files
          && !name.StartsWith("__")
          // filter out .Part ... files
          && !name.Contains(".Part ");
      })
      .Select(f => f.Substring(App.PhysicalPath.Length + 1))
      .ToArray();
  }
  
  public bool HasAutoAssets(string path) {
    var mainPath = Path.GetDirectoryName(path); //GetFullPath(path));
    var assetsPath = mainPath + "\\__Assets.cshtml";
    var exists = File.Exists(assetsPath);
    return exists; 
    // return assetsPath + exists;
    // return true;
  }
}