﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testapp4.Models;
using testapp4.ViewModels;

namespace testapp4.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Fidesz Párttagok listája"
            };
            var costumer = new List<Costumer>
            {
                new Costumer {Name = "Orbán Viktor"},
                 new Costumer {Name = "Szijjártó Péter"},
                  new Costumer {Name = "Kósa Lajos"},
                new Costumer {Name = "Rogán Antal"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Costumers = costumer
            };
            return View(viewModel);

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}