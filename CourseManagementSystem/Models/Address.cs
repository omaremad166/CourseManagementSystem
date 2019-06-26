using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Address
    {
        [ForeignKey("Student")]
        public int AddressId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Student Student { get; set; }
    }
}