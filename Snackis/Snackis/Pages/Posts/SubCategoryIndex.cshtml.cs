using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Posts
{
    public class SubCategoryIndexModel : PageModel
    {
        private readonly Snackis.Data.SubCatDBContext _subCatContext;
        private readonly Snackis.Data.CategoriesDBContext _context;

        public SubCategoryIndexModel(Snackis.Data.SubCatDBContext subCatContext, Snackis.Data.CategoriesDBContext context)
        {
            _subCatContext = subCatContext;
            _context = context;
        }

        public IList<SubCategory> SubCategoryList { get;set; }
        public IList<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            CategoryList = await _context.Categories.ToListAsync();
            SubCategoryList = await _subCatContext.SubCategories.ToListAsync();

            if (id == null)
            {
                return Page();
            }

            SubCategory = await _subCatContext.SubCategories.FirstOrDefaultAsync(m => m.CategoryID == id);

            if (SubCategory == null)
            {
                return Page();
            }
            return Page();
            
        }
    }
}
