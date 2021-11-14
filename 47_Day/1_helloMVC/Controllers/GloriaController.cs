using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_helloMVC.Controllers
{
    public class GloriaController : Controller
    {
        // GET: Gloria
        public string Index()
        {
            return "Gloria Index";
        }

        public string Contact()
        {
            return "Gloria Contact";
        }

        public string Project()
        {
            return "Gloria Project";
        }

    }
}