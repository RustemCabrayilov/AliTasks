namespace DependencyInjection;

public class GmailService : IMailService
{
    public void Send(string message)
    {
        Console.WriteLine("GmailService is working");
    }
}