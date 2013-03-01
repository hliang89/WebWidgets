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

        public string Welcome(string name)
        {
            return HttpUtility.HtmlEncode(String.Format("Hello {0}. It is now {1}", name, DateTime.Now.ToShortDateString()));
        }


    }
}
