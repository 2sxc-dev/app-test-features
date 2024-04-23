namespace AppCode.Mails
{
  public interface IMailGenerator
  {
    string Title(string title);

    string Body(string body);
  }
}