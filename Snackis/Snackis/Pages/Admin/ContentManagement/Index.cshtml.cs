using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;
using System.ComponentModel.DataAnnotations;

namespace Snackis.Pages.Admin.ContentManagement
{
    public class IndexModel : PageModel
    {
        private readonly Snackis.Data.CategoriesDBContext _context;

        public IndexModel(Snackis.Data.CategoriesDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        [Display(Name = "Kategori")]
        public Category Category { get; set; }

        public IList<Category> Categories { get;set; }

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
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
