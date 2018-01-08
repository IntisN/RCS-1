using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    using System.Data.Entity;

    public class BlogDb : DbContext
    {

        //DbSet - nosīmē jauna tabula, jauns sets. Ja uztaisam jaunu datubāzi, to taisam jaunā Klasē (Class)
        //šeit pievienojam public DbSet<........> {get, set;} - un pievienojam, ka mums ir vēl viena tabula, kur glabājas 
        //kaut kādi dati!
        public DbSet<Blog> BlogProfiles { get; set; }

      

    }
}

