using DesignPatterns.Creational.Factory.EmailProviderScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.EmailProviderScenerio.Concretes;
public class GoogleEmail : IEmailSendService
{
    public void SendEmail()
    {
        Console.WriteLine("Email has been sent by | Google | provider");
    }
}
