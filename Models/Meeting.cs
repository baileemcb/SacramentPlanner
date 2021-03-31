using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentSong { get; set; }
        public string ClosingSong { get; set; }
        public string SpecialSong { get; set; }
        public string Conductor { get; set; }
        public ICollection<Speaker> Speakers { get; set; }


    }
}
