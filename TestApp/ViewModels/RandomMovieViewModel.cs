using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testapp4.Models;

namespace testapp4.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Costumer> Costumers { get; set; }
    }
}