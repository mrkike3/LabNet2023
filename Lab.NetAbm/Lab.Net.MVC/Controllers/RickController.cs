using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Net.MVC.Controllers
{
    public class RickController : Controller
    {
        // GET: Rick
        public ActionResult Index()
        {
            return View();
        }
    }
}