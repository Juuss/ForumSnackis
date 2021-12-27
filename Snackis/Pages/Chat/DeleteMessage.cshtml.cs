using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Chat
{
    public class DeleteMessageModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;

        public DeleteMessageModel(Snackis.Data.SnackisDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ChattMessage ChattMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChattMessage = await _context.ChattMessages.FirstOrDefaultAsync(m => m.Id == id);

            if (ChattMessage == null)
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

            ChattMessage = await _context.ChattMessages.FindAsync(id);

            if (ChattMessage != null)
            {
                _context.ChattMessages.Remove(ChattMessage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
