using System;
using System.Net.Http;

namespace Http
{
    internal class Http_Request
    {
        static void MakeRequest()
        {
            string targetUrl = "https://jsonplaceholder.typicode.com/users";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            string responseClient = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseClient);
        }

        static void Main(string[] args)
        {
            MakeRequest();
        }
    }
}
