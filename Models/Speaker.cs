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
        public string name { get; set; }

        [Required]
        [Display(Name = "Speaker Subject")]
        public string subject { get; set; }
    }
}
