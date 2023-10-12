using Microsoft.Extensions.Hosting;
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

        public async Task<Tråd[]> GetPosts()
        {
            string url = $"{baseAPI}Tråd/";
            return await http.GetFromJsonAsync<Tråd[]>(url);
        }

        public async Task<Tråd> GetPost(int id)
        {
            string url = $"{baseAPI}tråd/{id}/";
            return await http.GetFromJsonAsync<Tråd>(url);
        }
    }
}