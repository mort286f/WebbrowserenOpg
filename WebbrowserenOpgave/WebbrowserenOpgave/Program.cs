using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebbrowserenOpgave
{
    class Program
    {
        public static HttpClient client = new HttpClient();

        public static async Task Main(string[] args)
        {
            HttpResponseMessage response = await client.GetAsync("http://www.google.com");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();

            string formattedResponseStr = Regex.Replace(responseString, "<[^>]*>", String.Empty);
            Console.WriteLine(formattedResponseStr);

            Console.ReadLine();
        }
    }
}
