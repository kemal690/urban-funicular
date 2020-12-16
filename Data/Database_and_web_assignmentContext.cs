using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Database_and_web_assignment.models;

namespace Database_and_web_assignment.Data
{
    public class Database_and_web_assignmentContext : DbContext
    {
        public Database_and_web_assignmentContext (DbContextOptions<Database_and_web_assignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Database_and_web_assignment.models.Students> Student { get; set; }

        public DbSet<Database_and_web_assignment.models.Venues> Venues { get; set; }

        public DbSet<Database_and_web_assignment.models.Admins> Admins { get; set; }

        public DbSet<Database_and_web_assignment.models.Teachers> Teachers { get; set; }

        public DbSet<Database_and_web_assignment.models.logins> logins { get; set; }

        public DbSet<Database_and_web_assignment.models.Courses> Course { get; set; }
    }
}
