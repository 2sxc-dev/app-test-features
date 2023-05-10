using ToSic.Eav.Data.Raw;
using System.Collections.Generic;
using System;
using System.Linq;
using ToSic.Eav.DataSource;
using ToSic.Eav.DataSource.VisualQuery;

public class TreeFoldersAndFiles : Custom.DataSource.DataSource16
{
  public TreeFoldersAndFiles(MyServices services) : base(services, "My.Magic")
  {
    // The "Default" stream contains both files and folders
    ProvideOut(() => {
      return new List<object> {
        CreateFolder("/", ""),            // Root Folder
          CreateFile("/", "Test.txt"),    // File in Root folder
          CreateFile("/", "Image.jpg"),   // File in Root Folder
          CreateFolder("/", "101"),       // Subfolder 101
            CreateFolder("/101", "1011"),
            CreateFolder("/101", "1012"),
            CreateFile("/101", "Text in 101.txt"),
          CreateFolder("/", "102"),       // Subfolder 102
      };
    });
    ProvideOut(() => TryGetOut("Default").Where(f => !f.Get<bool>("IsFile")), name: "Folders");
    ProvideOut(() => TryGetOut("Default").Where(f => f.Get<bool>("IsFile")), name: "Files");
  }


  private object CreateFile(string path, string name) {
    path = path.ToLowerInvariant();
    var fullPath = (path + "/" + name).ToLowerInvariant();
    return new {
      IsFile = true,
      Path = fullPath,
      Title = "File " + name,
      // Find entities (one expected) which have a key saying they are the folder
      Parent = new { Relationships = new [] { "folder:" + path } },

      RelationshipKeys = new [] {
        "file:" + fullPath,
        "file-in:" + path
      },
    };
  }
  private object CreateFolder(string parent, string name) {
    parent = parent.ToLowerInvariant();
    var path = (parent + name).ToLowerInvariant();
    var parentPath = (path == "/" ? "" : parent).ToLowerInvariant();
    return new {
      IsFile = false,
      Path = path,
      Title = "Folder " + path,
      // Files should list all files which have this folder as parent
      Files = new { Relationships = new [] { "file-in:" + path } },
      // Folders should list all folders which have this folder as parent
      Folders = new { Relationships = new [] { "folder-in:" + path } },
      // Parent should point to the folder which is the parent of this folder
      Parent = new { Relationships = new [] { "folder:" + parent } },

      RelationshipKeys = new [] {
        "folder:" + path,           // So files can find this as the parent folder
        "folder-in:" + parentPath,  // Mark this for pickup for the parent-folder
      },
    };
  }
}
