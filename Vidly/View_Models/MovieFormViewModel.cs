using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.View_Models
{
    public class MovieFormViewModel
    {
        public List<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}