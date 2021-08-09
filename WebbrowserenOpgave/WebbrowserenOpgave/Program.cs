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
        //New HttpClient instance. You are only supposed to have one instance open per application to minimize exhaust.
        public static HttpClient client = new HttpClient();

        //A c# task. This represents an asynchronous method or operation. 
        public static async Task Main(string[] args)
        {
            //Represents a http response
            HttpResponseMessage response = await client.GetAsync("http://www.google.com");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();

            //String formatter. The replace method formats the input string based on which characters is specified to be removed
            //and returns a new string
            string formattedResponseStr = Regex.Replace(responseString, "<[^>]*>", String.Empty);
            Console.WriteLine(formattedResponseStr);

            Console.ReadLine();
        }
    }
}
