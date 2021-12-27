using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.ContentManagement
{
    public class DetailsModel : PageModel
    {
        private readonly SnackisDBContext _context;

        public DetailsModel(SnackisDBContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }
        public List<SubCategory> SubCategories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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
    }
}
