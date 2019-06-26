using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}