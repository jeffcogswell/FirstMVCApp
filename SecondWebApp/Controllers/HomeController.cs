using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondWebApp.Controllers
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

        public ActionResult Demo()
        {
            List<string> mylist = new List<string>();
            mylist.Add("Hello");
            mylist.Add("There");
            mylist.Add("World");
            mylist.Add("Have a great day");

            ViewBag.List = mylist;
            return View();
        }

        public ActionResult Test()
        {
            return Content("This is a test!");
        }
    }
}