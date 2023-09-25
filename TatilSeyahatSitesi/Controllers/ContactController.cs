using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class ContactController : Controller
    {
        Context db = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            var values = db.Contacts.ToList();
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Contact contact) 
        {
            var value = db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
        
        public ActionResult PartialContact(Contact contact)
        {
            return PartialView();
        }
    }
}