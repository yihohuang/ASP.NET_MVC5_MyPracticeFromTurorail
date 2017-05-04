using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialPractice.Models
{
    public class UserModel
    {
        public int UserId { get; internal set; }
        public string UserName { get; internal set; }
        public string Company { get; set; }
    }
}