using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Database_and_web_assignment.Data;
using Database_and_web_assignment.models;

namespace Database_and_web_assignment.Pages.Course
{
    public class IndexModel : PageModel
    {
        private readonly Database_and_web_assignment.Data.Database_and_web_assignmentContext _context;

        public IndexModel(Database_and_web_assignment.Data.Database_and_web_assignmentContext context)
        {
            _context = context;
        }

        public IList<Courses> Courses { get;set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Course.ToListAsync();
        }
    }
}
