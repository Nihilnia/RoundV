using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_htmlContent.Controllers
{
    public class OtherPagesController : Controller
    {
        // GET: OtherPages
        public ViewResult FullWidthPage()
        {
            return View();
        }

        public ViewResult SideBarPage()
        {
            return View();
        }

        public ViewResult FAQ()
        {
            return View();
        }

        public ViewResult NotFound()
        {
            return View();
        }
    }
}