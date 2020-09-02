using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Web.Pages.Notes
{
    public class DeleteModel : PageModel
    {
        private readonly ToDo.Data.ToDoDbContext _context;

        public DeleteModel(ToDo.Data.ToDoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Note Note { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Notes.FirstOrDefaultAsync(m => m.id == id);

            if (Note == null)
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

            Note = await _context.Notes.FindAsync(id);

            if (Note != null)
            {
                _context.Notes.Remove(Note);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
