using Microsoft.Extensions.Hosting;
using System.Text.Json;
using webAPIMiniReddit.Model;
namespace webAPIMiniReddit.Services
{
    public class Api_Service
    {
        private readonly DataContext _dc;
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";

        public Api_Service(DataContext dc) 
        {
            _dc = dc;
        }

        public async Task<Traad[]> GetPosts()
        {
            return _dc.Traade.ToArray();
        }


        public async Task<Kommentar> CreateComment(string text, int idKommentar, string brugerKommentar)
        {
            _dc.Kommentare.Add(new Kommentar()
            {
                idKommentar = idKommentar,
                brugerKommentar = brugerKommentar,
                text = text,
                dato = DateTime.Now
            });
            _dc.SaveChanges();
            return (await _dc.Kommentare.FindAsync(idKommentar))!;
        }

    }
}