using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWeb.Models;

namespace MovieWeb.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}