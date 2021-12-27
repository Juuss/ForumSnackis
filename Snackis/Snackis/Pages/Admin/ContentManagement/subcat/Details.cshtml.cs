using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;

namespace Snackis.Pages.Admin.ContentManagement.subcat
{
    public class DetailsModel : PageModel
    {
        private readonly Snackis.Data.SubCatDBContext _context;

        public DetailsModel(Snackis.Data.SubCatDBContext context)
        {
            _context = context;
        }

        public SubCategory SubCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubCategory = await _context.SubCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (SubCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
