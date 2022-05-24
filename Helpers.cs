using ToSic.Razor.Blade;
using ToSic.Sxc.Services;
using System.Web;
using System.Linq;
public class Helpers: Custom.Hybrid.Code12
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
    var fullPath = GetFullPath(filePath);
    var pathOnly = System.IO.Path.GetDirectoryName(fullPath);
    var subDirectories = System.IO.Directory.GetDirectories(pathOnly);
    return subDirectories.Select(sd => sd.Substring(App.PhysicalPath.Length + 1)).ToArray();
  }
}