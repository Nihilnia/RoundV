using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_helloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Home Index";
        }

        public string Contact()
        {
            return "Home Contact";
        }

        public string Links()
        {
            return "Home Links";
        }
    }
}