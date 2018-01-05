using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;
    //Lai varētu izmantot AddOrUpdate funkciju ir jāpieraksta šis usings, kas apakšā :)
    using System.Data.Entity.Migrations;

    public class CatsController : Controller
    {
        
        // GET: Cats
        public ActionResult Index()
        {
            //Lai varētu ievadīt un parādīt vairākus kaķus, ir jāizveido saraksts List ar mainīgo
            //var CatListFromDb = new List<CatProfile>();


            //taču mēs lista neko neglabāsim, glabāsim uzreiz datu bāzē, tapēc mēs listu dzesīsim arā, jo izveidojām datu bāzi CatDb


            //izveido pirmo kaķa profilu
            var catFromDb = new CatProfile();
            catFromDb.CatName = "Pūciņa";
            catFromDb.CatAge = 5;
            catFromDb.CatImage = "https://ichef.bbci.co.uk/images/ic/208x117/p0517py6.jpg";

            //Pievienojam šo kaķi sarakstam ar šo - CatListFromDb.Add(catFromDb), taču, tā kā mēs listu nelietojam
            //bet izveidojām datu bāzi, šo mēs zemāk aizstājam ar funkciju, kur pievienojam profilus datu bāzei "catDB"


            //Izveidojam otra kaķa profilu
            var anothercatFromDb = new CatProfile();
            anothercatFromDb.CatName = "Rexis";
            anothercatFromDb.CatAge = 4;
            anothercatFromDb.CatImage = "http://atlantaintownpaper.com/wp-content/uploads/2013/07/home-cat.jpg";



            using (var catDb = new CatDb())
            {
                //pievienojam kaķi datu bāzei
                //catDb.CatProfiles.Add(catFromDb);
                //catDb.CatProfiles.Add(anothercatFromDb);

                //saglabāt datu bāzē veiktās izmaiņas
                //catDb.SaveChanges();

                //tā kā, tagad visu laiku refrešojot pievienojās klāt tie paši kaķi atkal un atkal
                //kodus mēs pārveidojām kā komentāru :) (3 kodu augstāk)

                //iegūt kaķu sarakstu no kaķu datu bāzes tabulas
                var catListFromDb = catDb.CatProfiles.ToList();

                //iegūst skatu ar kaķiem no tabulas
                return View(catListFromDb);

            }
        }

       

        public ActionResult AddCats()
        {
            return View();
        }

        //mums ir jānorada, ka šī funkcija veic POST darbību
        //ja nenorādam, viņš saprot, ka funkcija, kas jāveic ir Get nevis POST

        [HttpPost]
        public ActionResult AddCats(CatProfile userCreatedCat)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }
            using (var CatDb = new CatDb())
            {
                CatDb.CatProfiles.Add(userCreatedCat);
                CatDb.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult EditCats(CatProfile catProfile)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }
            using (var CatDb = new CatDb())
            {
                CatDb.CatProfiles.AddOrUpdate(catProfile);
                CatDb.SaveChanges();

                
            }

            return RedirectToAction("Index");
        }
           
        public ActionResult EditCats(int editableCatId)
        {
          
            using (var CatDb = new CatDb())
            {
                var editableCat = CatDb.CatProfiles.First(CatProfile => CatProfile.CatID == editableCatId);
               
                CatDb.SaveChanges();

                return View("EditCats", editableCat);
            }


        }

        public ActionResult DeleteCats(int deletableCatId)
            {
                using (var catDb = new CatDb())
                {
                    //atrast kaķi ar konkreto Id numuru
                    var deletableCat = catDb.CatProfiles.First(CatProfile => CatProfile.CatID == deletableCatId);

                    //izdzēst šo kaķi no tabulas
                    catDb.CatProfiles.Remove(deletableCat);

                    //saglabat veiktās izmaiņas datu bāzē
                    catDb.SaveChanges();

                }

                //Jāpievieno using System.Net
                //pāvēlam browser atgriezties Index lapā (t.i. pārlādēt to)
                return RedirectToAction("Index");

            }
           
    }
}