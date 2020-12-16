using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.models
{
    public class Venues
    {
        [Key]
        public int Venue_ID { get; set; }
        public string Venue_Name { get; set; }
        public string Venue_Address { get; set; }
    }
}
