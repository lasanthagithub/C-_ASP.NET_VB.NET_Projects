﻿using eCommerse.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerse.WebUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext context = new DataContext();
            context.Customers

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