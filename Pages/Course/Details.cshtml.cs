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
    public class DetailsModel : PageModel
    {
        private readonly Database_and_web_assignment.Data.Database_and_web_assignmentContext _context;

        public DetailsModel(Database_and_web_assignment.Data.Database_and_web_assignmentContext context)
        {
            _context = context;
        }

        public Courses Courses { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Courses = await _context.Course.FirstOrDefaultAsync(m => m.Course_ID == id);

            if (Courses == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
