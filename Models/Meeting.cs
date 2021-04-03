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
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string ClosingPrayer { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string OpeningSong { get; set; }

        [Required]
        [Display(Name = "Sarcrament Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string SacramentSong { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string ClosingSong { get; set; }

        [Display(Name = "Special Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string SpecialSong { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string Conductor { get; set; }

        public int? SpeakerID { get; set; }
        public Speaker Speakers { get; set; }


    }
}
