using ToSic.Sxc.Data;
using ToSic.Razor.Blade;

/// <summary>
/// Just a blank class to check if the _CodeApiSvc matches
/// </summary>
public class CodeApiSvcInheritance : Custom.Hybrid.CodeTyped
{

  public dynamic GetSub() => GetCode("./CodeApiSvcInheritanceSub.cs");
}
