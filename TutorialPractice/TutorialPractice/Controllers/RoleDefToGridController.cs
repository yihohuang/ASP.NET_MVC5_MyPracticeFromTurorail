using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorialPractice.Models;

namespace TutorialPractice.Controllers
{
    public class RoleDefToGridController : Controller
    {
        // GET: RoleDefToGrid
        public ActionResult getRoleDef()
        {
            return View();
        }

        public JsonResult getRoleDefData()
        {
            //create fake data.
            var roleDefs = new List<RoleDefData>();

            roleDefs.Add
            (
                new RoleDefData
                {
                    roleId = 1,
                    comment = "Admin",
                    parentRoleId = 0,
                    active = true
                }
            );
            roleDefs.Add
            (
                new RoleDefData
                {
                    roleId = 2,
                    comment = "Farmer",
                    parentRoleId = 1,
                    active = true
                }
            );
            roleDefs.Add
            (
                new RoleDefData
                {
                    roleId = 3,
                    comment = "user",
                    parentRoleId = 2,
                    active = true
                }
            );

            return Json(roleDefs, JsonRequestBehavior.AllowGet);
        }
    }
}