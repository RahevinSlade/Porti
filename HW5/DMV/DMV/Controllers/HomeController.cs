﻿using System;
using DMV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Request()
        {
            return View();
        }

        public ActionResult Awaiting()
        {
            return View();
        }

    }
}