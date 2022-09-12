using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestcam.ShareScreen.Controllers
{
    public class OverviewController : Controller
    {
        // GET: Overview
        public ActionResult WelCome()
        {
            ViewBag.Title = "Welcome";
            ViewBag.bodyClass = "welcome-page";

            return View();
        }

        // GET: Overview
        public ActionResult Selection()
        {
            ViewBag.Title = "selection";
            ViewBag.bodyClass = "selection-page";
            return View();
        }

        // GET: Overview
        public ActionResult Download()
        {
            ViewBag.Title = "download";
            ViewBag.bodyClass = "download-page";
            return View();
        }
    }
}