//It gives permission to create to the subclasses

using DesignPatterns.Creational.Factory.EmailProviderScenerio.Abstracts;
using DesignPatterns.Creational.Factory.EmailProviderScenerio.Concretes;
using DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;
using DesignPatterns.Creational.Factory.LogisticScenerio.Concrete;

#region Logistics Scenerio
//Logistics logistics;

//logistics = new RoadLogistics();
//logistics.PlanDelivery();

//logistics = new SeaLogistics();
//logistics.PlanDelivery();
#endregion

#region Email Provider Scenerio
Providers providers;

providers = new CloudClientProvider();
providers.SendEmail();

providers = new OnPremiseClientProvider();
providers.SendEmail();

providers = new HybridClientProvider();
providers.SendEmail();

#endregion