using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpdesk_API_Integration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult Viewpage ()
        {
            return View();
        }

        public ActionResult Viewpagewithlayout ()
        {
            return View();
        }

        public ActionResult PartialPage ()
        {
            return View();
        }
        
    }
}