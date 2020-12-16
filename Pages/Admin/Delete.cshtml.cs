using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Database_and_web_assignment.Data;
using Database_and_web_assignment.models;

namespace Database_and_web_assignment.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly Database_and_web_assignment.Data.Database_and_web_assignmentContext _context;

        public DeleteModel(Database_and_web_assignment.Data.Database_and_web_assignmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Admins Admins { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Admins = await _context.Admins.FirstOrDefaultAsync(m => m.Admin_ID == id);

            if (Admins == null)
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

            Admins = await _context.Admins.FindAsync(id);

            if (Admins != null)
            {
                _context.Admins.Remove(Admins);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
