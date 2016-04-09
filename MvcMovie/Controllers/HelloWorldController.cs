using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index(string path)
        {
            
            ViewBag.cfs = path;
          
            return View();
        }
        public ActionResult Welcome(string name,int age)
        {
            ViewBag.Name =name;
            ViewBag.Age = age;
            return View();
        }

      
    }
}