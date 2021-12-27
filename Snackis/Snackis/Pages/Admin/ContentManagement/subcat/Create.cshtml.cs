using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.ContentManagement.subcat
{
    public class CreateModel : PageModel
    {
        private readonly Snackis.Data.SubCatDBContext _context;
        private readonly Snackis.Data.CategoriesDBContext _headContext;

        public CreateModel(Snackis.Data.SubCatDBContext context, Snackis.Data.CategoriesDBContext headContext)
        {
            _context = context;
            _headContext = headContext;
        }

        [BindProperty]
        public SubCategory SubCategory { get; set; }

        public Category Category { get; set; }

        public List<SubCategory> subCategories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _headContext.Categories.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }


            subCategories = _context.SubCategories.ToList();

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SubCategories.Add(SubCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/ContentManagement/Index");
        }
    }
}
