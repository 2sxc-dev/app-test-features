namespace AppCode.Mails
{
  public class BasicMailGenerator : IMailGenerator
  {
    public string Title(string title)
    {
      return $"<h1>{title}</h1>";
    }

    public string Body(string body)
    {
      return $"<p>{body}</p>";
    }
  }
}