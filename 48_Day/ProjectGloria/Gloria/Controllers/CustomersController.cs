using Gloria.ProjectGloria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gloria.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customers> allCustomers = new List<Customers>();

            using (var DB = new ProjectGloriaContext())
            {
                var daCustomers = DB.Customers.ToList();

                foreach (var f in daCustomers)
                {
                    allCustomers.Add(f);
                }
            }

            return View(allCustomers);
        }
    }
}