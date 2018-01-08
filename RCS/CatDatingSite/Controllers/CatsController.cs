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
    using System.Data.Entity;

    public class CatsController : Controller
    {
        // GET: Cats
        public ActionResult Index()
        {

            using (var catDb = new CatDb())
            {
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
                return View(userCreatedCat);
            }
            using (var CatDb = new CatDb())
            {
                CatDb.CatProfiles.Add(userCreatedCat);
                CatDb.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        //lai dabūtu failu, ko var pievienot serverī, pievieno HttpPosted.... + to, ko ievadijām pie EditCats apakšā name=uploadedPicture
        public ActionResult EditCats(CatProfile catProfile, HttpPostedFileBase uploadedPicture)
        {
            if (ModelState.IsValid == false)
            {
                return View(catProfile);
            }
            using (var CatDb = new CatDb())
            {
                var profilePic = new File();
                //saglabājam bildes faila nosaukumu
                profilePic.FileName = System.IO.Path.GetFileName(uploadedPicture.FileName);
                profilePic.ContentType = uploadedPicture.ContentType;

                 //BinaryReader pārvērš bildi baitos
                using (var reader = new System.IO.BinaryReader(uploadedPicture.InputStream))
                {
                    //saglabājam baitus datubāzes ierakstā
                    profilePic.Content = reader.ReadBytes(uploadedPicture.ContentLength);
                }

                profilePic.CatProfileId = catProfile.CatID;
                profilePic.CatProfile = catProfile;

                CatDb.Files.Add(profilePic);

                catProfile.ProfilePicture = profilePic;

                CatDb.Entry(catProfile).State = EntityState.Modified;
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