﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;


namespace TestApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }
    }
}