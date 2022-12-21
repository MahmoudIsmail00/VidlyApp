using ASP.Net_MVC_Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Fundamentals.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}