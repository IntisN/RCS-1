using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models

    //Lai izveidotu tabulu neizmantojot SQL, C# jaizmanto Entity Framwork bibliotēka
{
    using System.Data.Entity;

    public class CatDb : DbContext
    {
        //DbSet - nosīmē jauna tabula, jauns sets. Ja uztaisam jaunu datubāzi, to taisam jaunā Klasē (Class)
        //šeit pievienojam public DbSet<........> {get, set;} - un pievienojam, ka mums ir vēl viena tabula, kur glabājas 
        //kaut kādi dati!
        public DbSet<CatProfile> CatProfiles { get; set; }

        public DbSet<File> Files { get; set; }
    }

}