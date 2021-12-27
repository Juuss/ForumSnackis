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
        private readonly SnackisDBContext _context;
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public SubCategoryIndexModel(SnackisDBContext context, IInspoQuoteGateway gateway)
        {
            _context = context;
            _gateway = gateway;
        }

        public IList<SubCategory> SubCategoryList { get;set; }
        public IList<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }
        public InspoQuote RandomQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            CategoryList = await _context.Categories.ToListAsync();
            SubCategoryList = await _context.SubCategories.ToListAsync();
            RandomQuote = await _gateway.GetRandom();

            if (id == null)
            {
                return Page();
            }

            SubCategory = await _context.SubCategories.FirstOrDefaultAsync(m => m.CategoryID == id);

            if (SubCategory == null)
            {
                return Page();
            }
            return Page();
            
        }
    }
}
