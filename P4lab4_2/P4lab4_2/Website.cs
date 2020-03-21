using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P4lab4_2
{
    public class Website
    {
        public Website(string domain, string path, Method method = Method.GET)
        {
            _restClient = new RestClient(domain);
            _restRequest = new RestRequest(path, method);
        }
        private RestClient _restClient;
        private RestRequest _restRequest;

        public async Task<string> Download()
        {
            var response = await _restClient.ExecuteAsync(_restRequest);
            return response.Content;
        }
    }
}
