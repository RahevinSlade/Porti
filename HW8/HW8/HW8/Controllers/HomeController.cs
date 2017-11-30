﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;
using HW8.Models;
using System.Diagnostics;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private ArtistContext db = new ArtistContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArtistView()
        {
            return View(db.Artists.ToList());
        }

        public ActionResult ClassView()
        {
            var artClass = db.ArtWorks.Include(c => c.Works);
            return View(artClass.ToList());
        }
    }
}