using Microsoft.Extensions.Hosting;
using System.Net.Http.Json;
using System.Text.Json;
using webAPIMiniReddit.Model;
using static System.Net.Mime.MediaTypeNames;

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

        //Hent tråde
        public async Task<Traad[]> GetPosts(int id, string brugerTraad, string titel, string beskrivelse)
        {
            return _dc.Traade.ToArray();
        }

        //Opret tråde
        public async Task<Traad> CreatePost(int id, string brugerTraad, string titel, string beskrivelse)
        {
            _dc.Traade.Add(new Traad()
            {
                id = id,
                brugerTraad = brugerTraad,
                titel = titel,
                beskrivelse = beskrivelse,
                date = DateTime.Now,
            });
            _dc.SaveChanges();
            return (await _dc.Traade.FindAsync(id))!;
        }


        //Opret kommentar
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