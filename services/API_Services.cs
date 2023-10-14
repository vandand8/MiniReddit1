using Microsoft.Extensions.Hosting;
using System.Net.Http.Json;
using System.Text.Json;
using webAPIMiniReddit.Model;
namespace webAPIMiniReddit.API_Services
{
    public class Api_Service
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";

        public Api_Service(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
        }

        public async Task<Traad[]> GetPosts()
        {
            string url = $"{baseAPI}Traad/";
            return await http.GetFromJsonAsync<Traad[]>(url);
        }

        public async Task<Traad> GetPost(int id)
        {
            string url = $"{baseAPI}Traad/{id}/";
            return await http.GetFromJsonAsync<Traad>(url);
        }

        public async Task<Kommentar> CreateComment(string tIxt, int iddKommentar, int brugerIDD)
        {
            string url = $"{baseAPI}traade/{iddKommentar}/kommentar";

            // Post JSON to API, save the HttpResponseMessage
            HttpResponseMessage msg = await http.PostAsJsonAsync(url, new { tIxt, brugerIDD });

            // Get the JSON string from the response
            string json = msg.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON string to a Comment object
            Kommentar? newKommentar = JsonSerializer.Deserialize<Kommentar>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Ignore case when matching JSON properties to C# properties 
            });

            // Return the new comment 
            return newKommentar;
        }
    }
}