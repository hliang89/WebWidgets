using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWidget1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name)
        {
            ViewBag.Name = (String.IsNullOrEmpty(name)) ? "User" : name;
            ViewBag.Name = name ?? "User";
            ViewBag.DateNow = DateTime.Now.ToShortTimeString();

            return View();
        }


    }
}
