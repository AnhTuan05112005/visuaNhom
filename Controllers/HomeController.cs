using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Trangtrudong()
        {
            return View();
        }

        public ActionResult TrangSanPhamAnLien()
        {
            return View();
        }

        public ActionResult TrangwebBanKem()
        {
            return View();
        }
        public ActionResult TrangwebBanbia()
        {
            return View();
        }
        public ActionResult Diachi()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}