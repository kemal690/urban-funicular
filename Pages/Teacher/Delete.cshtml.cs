using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Database_and_web_assignment.Data;
using Database_and_web_assignment.models;

namespace Database_and_web_assignment.Pages.Teacher
{
    public class DeleteModel : PageModel
    {
        private readonly Database_and_web_assignment.Data.Database_and_web_assignmentContext _context;

        public DeleteModel(Database_and_web_assignment.Data.Database_and_web_assignmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teachers Teachers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teachers = await _context.Teachers.FirstOrDefaultAsync(m => m.Teacher_ID == id);

            if (Teachers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teachers = await _context.Teachers.FindAsync(id);

            if (Teachers != null)
            {
                _context.Teachers.Remove(Teachers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
