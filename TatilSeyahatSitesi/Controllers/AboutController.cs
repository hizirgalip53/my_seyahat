using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;
namespace TatilSeyahatSitesi.Controllers
{
    public class AboutController : Controller
    {

        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Hakkimizdas.ToList();
            return View(values);
        }
    }
}