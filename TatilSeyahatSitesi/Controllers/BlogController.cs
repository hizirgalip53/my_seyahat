using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;
namespace TatilSeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Value1 = db.Blogs.ToList();
            by.Value3 = db.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            //var values = db.Blogs.ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {
            by.Value1 = db.Blogs.Where(x => x.ID == id).ToList();
            by.Value2 = db.Yorumlars.Where(x => x.Blogid == id).ToList();
            //var blogbul=db.Blogs.Where(x=>x.ID==id).ToList();   
            return View(by);
        }
        [HttpGet]
        public PartialViewResult BlogYorumEkle(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult BlogYorumEkle(Yorumlar y)
        {
            db.Yorumlars.Add(y);
            db.SaveChanges();
            return PartialView();
        }
    }
}