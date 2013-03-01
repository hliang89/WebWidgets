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

        public string Index()
        {
            return "This is my <b>default</b> response.";
        }

        public string Welcome()
        {
            return "Welcome to <b>Hello World<b/> response.";
        }


    }
}
