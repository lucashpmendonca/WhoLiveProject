﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WhoLiveApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Residents()
        {
            ViewBag.Message = "Your residents page.";

            return View();
        }

        public ActionResult Vehicles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Staffs()
        {
            ViewBag.Message = "Your staffs page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }
        
        public ActionResult Apartaments()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

    }
}