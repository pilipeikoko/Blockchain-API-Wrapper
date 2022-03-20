namespace BlockchainScanner.Dtos.Requests
{
    public sealed class MainTokenBalanceRequest : Request
    {
        public MainTokenBalanceRequest(string apiUrl, string module, string action, string apiKey, string address, string tag) :
            base(apiUrl, module, action, apiKey)
        {
            Map.Add("address", address);
            Map.Add("tag",tag);
        }
    }
}