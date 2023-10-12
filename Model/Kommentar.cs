using System.ComponentModel.DataAnnotations;

namespace webAPIMiniReddit.Model
{
    public class Kommentar
    {
        [Key]
        public int idKommentar { get; set; }
        public string brugerKommentar { get; set; }
        public string text { get; set; }
        public DateTime dato { get; set; }

    }
}
