using EsempioPJ20.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace EsempioPJ20
{
    class Program
    {
        const string TOKEN = "replace_with_your_token";
        const string TRACERS_URL = "https://hello.pj20tracer.it/api/v1/tracers";
        const string CONTACTS_URL = "https://hello.pj20tracer.it/api/v1/contacts?upload-date-from=2020-06-20T08:30:00Z&upload-date-to=2020-07-20T08:30:00Z";

        static async Task Main(string[] args)
        {
            var tracers = await GetFromPJ20<TracersResponse>(TRACERS_URL);

            var contacts = await GetFromPJ20<ContactsResponse>(CONTACTS_URL);
        }

        static async Task<T> GetFromPJ20<T>(string url)
        {
            using HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
            var httpResponse = await httpClient.GetAsync(url);
            httpResponse.EnsureSuccessStatusCode();
            string responseBody = await httpResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseBody);

        }
    }
}
