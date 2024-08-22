namespace DesignPatterns.Structural.Adapter;
public class CommunicationAdapter : ICommunicationResult
{
    private HttpCommunication _httpCommunication;

    public CommunicationAdapter(HttpCommunication httpCommunication)
    {
        _httpCommunication = httpCommunication;
    }

    public string GetCommunication()
    {
        return $"Adapted to Client => {_httpCommunication.HttpResult()}";
    }
}
