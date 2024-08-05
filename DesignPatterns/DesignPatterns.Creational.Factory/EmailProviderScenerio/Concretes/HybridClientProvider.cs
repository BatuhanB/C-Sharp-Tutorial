using DesignPatterns.Creational.Factory.EmailProviderScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.EmailProviderScenerio.Concretes;
public class HybridClientProvider : Providers
{
    public override IEmailSendService CreateService()
    {
        return new YandexEmail();
    }
}
