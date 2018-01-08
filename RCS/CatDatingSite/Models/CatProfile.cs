using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models

    
{
    using System.ComponentModel.DataAnnotations;
    

    public class CatProfile

    { [Key]
        public int CatID { get; set; }
        [Display(Name = "Kaķa vārds")]
        [Required (ErrorMessage = "Vārdam noteikti jabūt norādītam")]
        public string CatName { get; set; }

        [Display(Name = "Kaķa vecums")]
        public int CatAge { get; set; }

        [Display (Name = "Kaķa attēls")]
        public string CatImage { get; set; }

        [Display (Name = "Kaķa apraksts")]
        public string CatDescription { get; set; }

        public virtual File ProfilePicture { get; set; }
    }
}