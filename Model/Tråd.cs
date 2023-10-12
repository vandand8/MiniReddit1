using System.ComponentModel.DataAnnotations;

namespace webAPIMiniReddit.Model
{
    public class Tråd
    {
        [Key]
        public int id { get; set; }
        public string brugerTråd { get; set; }
        public DateTime date { get; set; }
        public string titel { get; set; }
        public string beskrivelse { get; set; }
        public int stemOp { get; set; } = 0;
        public int stemNed { get; set; } = 0;

        public int totalStemmer { get; set; } = 0;
        public string ? kommentar { get; set; }
    }
}
