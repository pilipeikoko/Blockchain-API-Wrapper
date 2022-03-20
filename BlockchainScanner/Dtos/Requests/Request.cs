using System.Collections.Generic;
using System.Text;

namespace BlockchainScanner.Dtos.Requests
{
    public abstract class Request
    {
        protected string ApiUrl { get; }
        protected virtual Dictionary<string, string> Map { get; } = new();

        public Request(string apiUrl, string module, string action, string apiKey)
        {
            ApiUrl = apiUrl;

            Map.Add("module", module);
            Map.Add("action", action);
            Map.Add("apikey", apiKey);
        }

        public string GetUrl()
        {
            StringBuilder stringBuilder = new(ApiUrl + "?");

            foreach (var kvp in Map)
            {
                stringBuilder.Append("&" + kvp.Key + "=" + kvp.Value);
            }

            return stringBuilder.ToString();
        }
    }
}