namespace DependencyInjection;

public class OutLookService : IMailService
{
    public void Send(string message)
    {
        Console.WriteLine("OutLook service is working");
    }
}