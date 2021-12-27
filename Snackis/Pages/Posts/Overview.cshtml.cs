using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Posts
{
    public class OverviewModel : PageModel
    {
        private readonly SnackisDBContext _context;
        public IList<Category> Categories { get; set; }
        public IList<SubCategory> SubCategories { get; set; }
        public IList<Post> Posts { get; set; }

        public Category Category { get; set; }
        public Post Post { get; set; }
        public SubCategory SubCategory { get; set; }

        public OverviewModel(SnackisDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Categories = await _context.Categories.ToListAsync();
            SubCategories = await _context.SubCategories.ToListAsync();
            Posts = await _context.Posts.ToListAsync();
            if (id == null)
            {
                return Page();
            }

            SubCategory = await _context.SubCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (SubCategory == null)
            {
                return Page();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
