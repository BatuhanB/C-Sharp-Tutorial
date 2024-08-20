namespace DesignPatterns.Creational.Factory.EmailProviderScenerio.Abstracts;
public abstract class Providers
{
    public abstract IEmailSendService CreateService();

    public void SendEmail()
    {
        var service = CreateService();
        service.SendEmail();
    }
}
