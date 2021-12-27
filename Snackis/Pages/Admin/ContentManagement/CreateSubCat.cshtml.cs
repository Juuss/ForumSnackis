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

namespace Snackis.Pages.Admin.ContentManagement
{
    public class CreateSubCatModel : PageModel
    {
        private readonly SnackisDBContext _context;

        public CreateSubCatModel(SnackisDBContext context)
        {
            _context = context;
        }

        public List<SubCategory> SubCategories { get; set; }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            SubCategories = await _context.SubCategories.Where(m => m.CategoryID == id).ToListAsync();

            if (Category == null)
            {
                return NotFound();
            }

            return Page();
        }

        [BindProperty]
        public SubCategory SubCategory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SubCategories.Add(SubCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { id = SubCategory.CategoryID });
        }
    }
}
