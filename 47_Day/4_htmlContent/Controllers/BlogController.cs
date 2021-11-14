using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_htmlContent.Controllers
{
    public class BlogController : Controller
    {
        / GET: Blog
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Home()
        {
            return View();
        }

        public ViewResult Post()
        {
            return View();
        }
    }
}