using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.models
{
    public class Teachers
    {
        [Key]
        public int Teacher_ID { get; set; }
        public int Teacher_First_Name { get; set; }
        public int Teacher_Last_Name { get; set; }
        public int Teacher_Email { get; set; }
        public int Teacher_Mobile_Number { get; set; }
        public int Teacher_Address { get; set; }
    }
}
