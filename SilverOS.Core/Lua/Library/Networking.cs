using RestSharp;

namespace SilverOS.Core.Lua.Library
{
    class Networking
    {
        public IRestResponse Get(string url)
        {
            var client = new RestClient(url);
            client.Timeout = SystemSettings.RequestTimeout;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            return client.Execute(request);
        }

        // POST request...
    }
}
