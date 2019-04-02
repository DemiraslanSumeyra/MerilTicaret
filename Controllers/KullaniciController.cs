using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerilTicaret.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hesabim()
        {
            return View();
        }

        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayitOl(int id)
        {
            return View();
        }

        public ActionResult GirisYap()
        {
            return View();
        }
    }
}