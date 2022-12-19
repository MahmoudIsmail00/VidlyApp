using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.Net_MVC_Fundamentals.Models;

namespace ASP.Net_MVC_Fundamentals.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer(){Id =1,  Name = "John Smith"},
                new Customer(){Id =2, Name = "Mary Williams"}
            };

            return View(customers);
        }
    }
}