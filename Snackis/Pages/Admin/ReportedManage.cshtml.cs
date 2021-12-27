using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin
{
    public class ReportedManageModel : PageModel
    {
        private readonly SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public ReportedManageModel(SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public Post Post { get; set; }
        public SubCategory SubCategory { get; set; }
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Category = await _context.Categories.Where(c => c.Id == id).FirstOrDefaultAsync();
            SubCategory = await _context.SubCategories.Where(sc => sc.Id == id).FirstOrDefaultAsync();


            if (id == null)
            {
                return NotFound();
            }

            Post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(Post.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}