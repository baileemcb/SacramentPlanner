using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Speaker Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string name { get; set; }

        [Required]
        [Display(Name = "Speaker Subject")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(100, MinimumLength = 3)]
        public string subject { get; set; }

        public int? MeetingID { get; set; }
    }
}
