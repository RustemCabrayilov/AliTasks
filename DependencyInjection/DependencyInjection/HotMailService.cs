namespace DependencyInjection;

public class HotMailService : IMailService
{
    public void Send(string message)
    {
        Console.WriteLine("HotmailService is working");
    }
}