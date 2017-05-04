/* this controller is for tutorial 
 * "Part 3 - VIEW in Asp.net MVC (Model-View -Controller)" 
 * youtube link : https://www.youtube.com/watch?v=Pt2UoRFuT-Y */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using TutorialPractice.Models;
using System.Web.Script.Serialization;

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

            //String str = "data source = .; ";
            //SqlConnection connection = new SqlConnection();

            return View();
        }

        public ActionResult roleDef()
        {
            return View();
        }

        public ActionResult TestJson()
        {
            List<string> list = new List<string>();

            list.Add("user_1");
            list.Add("user_2");
            list.Add("user_3");
            list.Add("user_4");

            //var json_string = "{ "FirstName" = "Jalpesh", "LastName" = "Vadgama" }";
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult WelcomeNote()
        {
            bool isAdmin = false;
            //TODO: Check the user if it is admin or normal user, (true-Admin, false- Normal user)  
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        private List<UserModel> GetUsers()
        {
            var usersList = new List<UserModel>
            {
                new UserModel
                {
                    UserId = 1,
                    UserName = "Ram",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "chand",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }

        public ActionResult GetUsersData()
        {
            //var users = GetUsers();
            //return Json(users, JsonRequestBehavior.AllowGet);
            return View();
        }

        [HttpPost]
        public JsonResult UpdateUsersDetail(string usersJson)
        {
            //get data from front-end.
            var js = new JavaScriptSerializer();
            UserModel[] user = js.Deserialize<UserModel[]>(usersJson);

            //TODO: user now contains the details, you can do required operations  
            return Json("User Details are updated");
        }
    }
}