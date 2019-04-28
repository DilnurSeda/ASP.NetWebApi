using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NetWebApi.Controllers
{
    public class PersonellerController : Controller
    {
        // GET: Personeller
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TumPersoneller()
        {
            return View();
        }

        public ActionResult PersonelGetir()
        {
            return View();
        }

        public ActionResult YeniPersonel()
        {
            return View();
        }
    }
}