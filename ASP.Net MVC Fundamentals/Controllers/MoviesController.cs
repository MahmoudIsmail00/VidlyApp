using ASP.Net_MVC_Fundamentals.Models;

using System.Collections.Generic;
using System.Web.Mvc;

namespace ASP.Net_MVC_Fundamentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie

        public ActionResult Index()
        {

            var movies = new List<Movie>
            {
                new Movie(){Id = 1,Name = "Shrek"},
                new Movie(){Id = 2,Name = "Wall-e"}
            };
            return View(movies);
        }
        
    }
}