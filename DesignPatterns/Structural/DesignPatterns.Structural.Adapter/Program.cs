using DesignPatterns.Structural.Adapter;

var httpComm = new HttpCommunication();

Console.WriteLine("Fetched from Http Communication:");
Console.WriteLine(httpComm.HttpResult());

Console.WriteLine("\n");

var adapter = new CommunicationAdapter(httpComm);

Console.WriteLine("Fetched from Adapter for the Client:");
Console.WriteLine(adapter.GetCommunication());