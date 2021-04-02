using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }

        [Required]
        [Display(Name = "Sarcrament Song")]
        public string SacramentSong { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }

        [Display(Name = "Special Song")]
        public string SpecialSong { get; set; }
        public string Conductor { get; set; }

        public int? SpeakerID { get; set; }
        public Speaker Speakers { get; set; }


    }
}
