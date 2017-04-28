using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        /* the tutorial of "Step-by-step ASP.NET MVC Tutorial for Beginners, Part 1" */
        /* youtube link : 
         * https://www.youtube.com/watch?v=6adg6DRfIHI&index=1&list=PLM5JAv_WpgH_FKWlsGkbiKUczG4BU8mv5
         * open the browser and enter the link : 
         * http://localhost:51686/home/HelloWorld 
         * will see "Hello World" in the web page. */
        public string helloWorld()
        {
            return "Hello World!";
        }

        /* the tutorial of "Step-by-step ASP.NET MVC Tutorial for Beginners, Part 1" */
        /* try link with parameter(name) : 
         * http://localhost:51686/home/inputName?name=burabura 
         * will see the output string u input in the web page. */
        public string inputName(string name)
        {
            return name;
        }

        /* please see the "Part 2 - CONTROLLER in Asp.net MVC | Role of Routing in MVC"
         * youtube link :
           https://www.youtube.com/watch?v=g2GbL4hPOMg&spfreload=1 */
        //public string getName(string name)
        //{
        //    return name;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
