using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.models
{
    public class Admins
    {
        [Key]
        public int Admin_ID { get; set; }
        public int Admin_First_Name { get; set; }
        public int Admin_Last_Name { get; set; }
        public int Admin_Email { get; set; }
        public int Admin_Mobile_Number { get; set; }
        public int Admin_Address { get; set; }
    }
}
