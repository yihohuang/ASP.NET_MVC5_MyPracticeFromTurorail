/* this controller is for tutorial 
 * "Part 3 - VIEW in Asp.net MVC (Model-View -Controller)" 
 * youtube link : https://www.youtube.com/watch?v=Pt2UoRFuT-Y */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialPractice.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Name = "your_name";
            List<string> list = new List<string>();

            list.Add("user_1");
            list.Add("user_2");
            list.Add("user_3");
            list.Add("user_4");

            ViewBag.list = list;

            return View();
        }
    }
}