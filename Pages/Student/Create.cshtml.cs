using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database_and_web_assignment.Data;
using Database_and_web_assignment.models;

namespace Database_and_web_assignment.Pages.Student
{
    public class CreateModel : PageModel
    {
        private readonly Database_and_web_assignment.Data.Database_and_web_assignmentContext _context;

        public CreateModel(Database_and_web_assignment.Data.Database_and_web_assignmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Students Students { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Students);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
