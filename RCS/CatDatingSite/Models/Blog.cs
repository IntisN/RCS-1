using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    public class Blog
    {
        
        [Key]
        public int BlogID { get; set; }
        [Display(Name = "Virsraksts")]
        [Required(ErrorMessage = "Virsrakstam noteikti jabūt norādītam")]
        public string BlogName { get; set; }

        [Display(Name = "Autora vārds")]
        public string BlogAuthor { get; set; }

        [Display(Name = "Bloga bilde")]
        public string BlogImage { get; set; }

        [Display(Name = "Bloga saturs")]
        public string BlogDescription { get; set; }

        public virtual BlogFiles BlogPictures { get; set; }
    }
}
