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
    public class IndexModel : PageModel
    {
        private readonly Snackis.Data.SubCatDBContext _context;

        public IndexModel(Snackis.Data.SubCatDBContext context)
        {
            _context = context;
        }

        public IList<SubCategory> SubCategory { get;set; }

        public async Task OnGetAsync()
        {
            SubCategory = await _context.SubCategories.ToListAsync();

        }
    }
}
