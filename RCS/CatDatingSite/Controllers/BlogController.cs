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

    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {

            using (var blogDb = new BlogDb())
            {

                //iegūt blogu sarakstu no blogu datu bāzes tabulas
                var blogListFromDb = blogDb.BlogProfiles.ToList();

                //iegūst skatu ar blogiem no tabulas
                return View(blogListFromDb);

            }

        }
        public ActionResult AddBlog()
        {
            return View();
        }

        public ActionResult DeleteBlog(int deletableBlogId)
        {
            using (var BlogDb = new BlogDb())
            {
                //atrast blogu ar konkreto Id numuru
                var removableBlog = BlogDb.BlogProfiles.First(BlogProfiles => BlogProfiles.BlogID == deletableBlogId);

                //izdzēst šo blogu no tabulas
                BlogDb.BlogProfiles.Remove(removableBlog);

                //saglabat veiktās izmaiņas datu bāzē
                BlogDb.SaveChanges();

                return RedirectToAction("Index");
            }

        }

        //mums ir jānorada, ka šī funkcija veic POST darbību
        //ja nenorādam, viņš saprot, ka funkcija, kas jāveic ir Get nevis POST
        [HttpPost]
        public ActionResult AddBlog(Blog userCreatedBlog)
        {
            if (ModelState.IsValid == false)
            {
                return View(userCreatedBlog);
            }

            using (var BlogDb = new BlogDb())
            {
                BlogDb.BlogProfiles.Add(userCreatedBlog);
                BlogDb.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        //
        public ActionResult EditBlog(Blog blogs)
        {
            if (ModelState.IsValid == false)
            {
                return View(blogs);
            }
            using (var BlogDb = new BlogDb())
            {
                BlogDb.Entry(blogs).State = EntityState.Modified;
                BlogDb.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult EditBlog(int editableBlogId)
        {

            using (var BlogDb = new BlogDb())
            {
                var editableBlog = BlogDb.BlogProfiles.First(Blog => Blog.BlogID == editableBlogId);

                BlogDb.SaveChanges();

                return View("EditBlog", editableBlog);
            }


        }
    }
}