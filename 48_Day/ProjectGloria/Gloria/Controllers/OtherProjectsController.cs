using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gloria.Controllers
{
    public class OtherProjectsController : Controller
    {
        // GET: OtherProjects
        public ActionResult Downloader()
        {
            return View();
        }

        public ActionResult ImageReader()
        {
            return View();
        }

        public ActionResult PlaylistMaker()
        {
            return View();
        }
    }
}