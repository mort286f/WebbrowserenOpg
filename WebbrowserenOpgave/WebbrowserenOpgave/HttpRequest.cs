using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebbrowserenOpgave
{
    class HttpRequest
    {
        public HttpClient client = new HttpClient();
        public string responseString = "";
        public async Task Main()
        {
            HttpResponseMessage response = await client.GetAsync("http://www.google.com");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
    }
}
