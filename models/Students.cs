using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.models
{
    public class Students
    {
        [Key]
        public int Student_ID { get; set; } 
        public string Student_First_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public string Student_Mobile_Number { get; set; }
        public string Student_Address { get; set; }
        public string Student_Email { get; set; }
        public string Course_ID { get; set; }
    }

}
