using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SnackisDBContext _context;
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public IndexModel(SnackisDBContext context, IInspoQuoteGateway gateway)
        {
            _context = context;
            _gateway = gateway;
        }

        public IList<Category> Category { get; set; }
        public InspoQuote RandomQuote { get; set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
            RandomQuote = await _gateway.GetRandom();
        }
    }
}
