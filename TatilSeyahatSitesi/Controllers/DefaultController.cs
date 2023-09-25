using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class DefaultController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Blogs.Take(10).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values=db.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var value = db.Blogs.Where(x => x.ID == 6).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var values = db.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = db.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var value = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(value);
        }
    }
}