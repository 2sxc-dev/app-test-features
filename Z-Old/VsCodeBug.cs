// Note: reported 2023-10-30 by 2dm here:
// https://github.com/microsoft/vscode/issues/196958
public class VsCodeBug
{
  public void Test(string before, string problem = "see https://xyz.com", string after = null)
  {
    
    Test("before");
  }
}