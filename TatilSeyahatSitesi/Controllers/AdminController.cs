using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var values = db.Blogs.Find(id);
            db.Blogs.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateBlog(int id)
        {
            var values = db.Blogs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog b)
        {
            var values = db.Blogs.Find(b.ID);
            values.Baslik = b.Baslik;
            values.Tarih = b.Tarih;
            values.Aciklama = b.Aciklama;
            values.BlogImage = b.BlogImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var values = db.Yorumlars.ToList();
            return View(values);
        }
        public ActionResult DeleteYorum(int id)
        {
            var values = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(values);
            db.SaveChanges();
            return RedirectToAction("YorumListesi", "Admin");
        }
        [HttpGet]
        public ActionResult YorumGetir(int id)
        {
            var yorum = db.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }

        [HttpPost]
        public ActionResult UpdateYorum(Yorumlar y)
        {
            var yorum = db.Yorumlars.Find(y.ID);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Mail = y.Mail;
            yorum.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}