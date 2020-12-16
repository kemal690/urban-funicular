using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.models
{
    public class Courses
    {
        [Key]
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
    }
}
