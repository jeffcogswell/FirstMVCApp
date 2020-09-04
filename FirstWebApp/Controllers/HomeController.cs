using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
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

        public void PrepareContactPage()
        {
            ViewBag.Message = "Here is how to contact us!";
        }

        public ActionResult Contact()
        {
            PrepareContactPage();
            return View();
        }

        [HttpPost]
        public ActionResult ThankYou(string firstname, string lastname, string emailaddress)
        {

            if (emailaddress.IndexOf('@') == -1)
            {
                PrepareContactPage();
                ViewBag.Welcome = "Sorry! Not an email address";
                ViewBag.EmailStatusMessage = "Please make sure your email contains an @ symbol.<br />";
                return View("Contact");
                //return Redirect("/home/contact");
            }
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}!";
            return View();

        }

        public ActionResult Hello()
        {
            return Content($"<h2>The current time is {DateTime.Now}</h2>");
        }

        public ActionResult GetTime()
        {
            return View();
        }

        public ActionResult Test2()
        {
            WebUser user = new WebUser() { Name = "Jeff", Department = "IT" };
            return View(user);
        }
    }
}