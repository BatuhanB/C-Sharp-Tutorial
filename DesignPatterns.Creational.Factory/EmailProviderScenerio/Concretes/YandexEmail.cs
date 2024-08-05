using DesignPatterns.Creational.Factory.EmailProviderScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.EmailProviderScenerio.Concretes;
public class YandexEmail : IEmailSendService
{
    public void SendEmail()
    {
        Console.WriteLine("Email has been sent by | Yandex | provider");
    }
}
