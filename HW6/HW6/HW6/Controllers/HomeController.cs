﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW6.Models;
using System.Diagnostics;


namespace HW6.Controllers
{
    public class HomeController : Controller
    {
        HW6Context db = new HW6Context();

        public ActionResult Index()
        {
            return View();
        }

    }
}