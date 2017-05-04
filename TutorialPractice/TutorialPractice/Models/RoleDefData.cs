using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialPractice.Models
{
    public class RoleDefData
    {
        public int roleId { get; set; }
        public string comment { get; set; }
        public int parentRoleId { get; set; }
        public bool active { get; set; }
    }
}