using ToSic.Sxc.Demo;
using ToSic.Razor.Blade;

public class HomeHelpers : Custom.Hybrid.CodeTyped
{
  const string Home = "_Home.cshtml";
  const string OldDefault = "_default.cshtml";
  const string NewDefault = "Default.cshtml";
  public void GetAllPaths(out string root, out string cshtml, out string fullPath, out string testPath) {
    testPath = MyPage.Parameters["TestPath"];

    // If no path was given, use the current path
    root = App.Folder.PhysicalPath + (Text.Has(testPath) ? "/" + testPath : "/");
    fullPath = root + Home;

    // Show Home if no path was given
    cshtml = Text.First(testPath, Home);
    
    if (!cshtml.Contains(".cshtml")) {
      cshtml = cshtml + OldDefault;
      fullPath = root + OldDefault; // already has the path, just missing the file
      // Check if _default exists...
      if (!System.IO.File.Exists(fullPath)) {
        fullPath = root + NewDefault;
        cshtml = cshtml.Replace(OldDefault, NewDefault);
        root = root.Replace(OldDefault, NewDefault);

        // If the new default doesn't exist, return null so the page can skip showing it
        if (!System.IO.File.Exists(fullPath))
          cshtml = null;
      }
    }
  }
}
