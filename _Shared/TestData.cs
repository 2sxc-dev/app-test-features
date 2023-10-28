using ToSic.Sxc.Data;
using System.Linq;

// Important notes: 
// - This class should have the same name as the file it's in
public class TestData : Custom.Hybrid.CodeTyped
{
  /// <summary>
  /// Get a test item by type and testId
  /// </summary>
  /// <param name="type"></param>
  /// <param name="testId"></param>
  /// <returns></returns>
  public ITypedItem Find(string type, string testId) {
    return AsItems(App.Data[type]).FirstOrDefault(i => i.String("TestId") == testId);
  }
}
