namespace DependencyInjection;

//MailService Gmail ve ya HotMail servislerden birinen six asilidi
public class MailService
{
    public IMailService service;

    public MailService(IMailService service)
    {
        this.service = service;
    }

    public void SendMessageToUser()
    {
        service.Send("message");
    }
}