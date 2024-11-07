using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Http
{
    internal class Http_Request_Await
    {
        static async Task MakeRequestAsync(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/users/{id}";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(targetUrl);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }

        static async Task Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                await MakeRequestAsync(i);
            }
        }
    }
}
