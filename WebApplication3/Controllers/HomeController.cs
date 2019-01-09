using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        private static List<string> comments = new List<string>();

        public ActionResult IndexComment()
        {
            return View(comments);
        }

        [HttpPost]
        public ActionResult AddComment(string comment)
        {
            //save new comment
            comments.Add(comment);

            //return RedirectToAction("IndexComment");
            if (Request.IsAjaxRequest())
            {
                ViewBag.Comment = comment;
                return PartialView();
            }
            return View();
        }

        public ActionResult IndexAjaxOption()
        {
            return View();
        }

        public ActionResult AppointmentData()
        {
            Thread.Sleep(5000);
            return PartialView();
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