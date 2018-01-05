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
        [Required]
        public string CatName { get; set; }
        public int CatAge { get; set; }
        public string CatImage { get; set; }
        public string CatDescription { get; set; }
    }
}