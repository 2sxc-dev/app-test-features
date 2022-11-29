using System;

public class TestLog
{
  public bool SimpleTest(ToSic.Eav.Logging.ILog log)
  {
    log.Add("test1");
    log.Add("test2");
    return ((log as ToSic.Sxc.Code.ICodeLog).GetContents() as ToSic.Lib.Logging.Log).Entries.Count == 2;
  }
  public string DumpLog(ToSic.Eav.Logging.ILog log)
  {
    return Dump(log);
  }
  public string Dump(
    ToSic.Eav.Logging.ILog log,
    string separator = " - ",
    string start = "",
    string end = "",
    string resultStart = "=>",
    string resultEnd = "",
    bool withCaller = false,
    string callStart = "",
    string callEnd = ""
  )
  {
    var lg = new System.Text.StringBuilder(start);
    ((log as ToSic.Sxc.Code.ICodeLog).GetContents() as ToSic.Lib.Logging.Log).Entries.ForEach(e => lg.AppendLine(e.Source
        + separator
        + new string('~', e.Depth * 2)
        + e.Message
        + (e.Result != null ? resultStart + e.Result + resultEnd : string.Empty)
        + EntryTime(e)
        + (withCaller && e.Code != null ? string.Format("{0}{1} - {2}() #{3}{4}", callStart, e.Code.Path, e.Code.Name, e.Code.Line, callEnd) : "")
    ));
    lg.Append(end);
    return lg.ToString();
  }

  private static string EntryTime(ToSic.Lib.Logging.Entry e) {
    return e.Elapsed != TimeSpan.Zero ? string.Format(" ⌚ {0}s ", e.Elapsed.TotalSeconds) : "";
  }

}
