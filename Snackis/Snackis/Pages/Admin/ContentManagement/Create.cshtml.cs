using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.ContentManagement
{
    public class CreateModel : PageModel
    {
        private readonly Snackis.Data.CategoriesDBContext _context;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;

        public CreateModel(Snackis.Data.CategoriesDBContext context, Snackis.Data.SubCatDBContext subCatContext)
        {
            _context = context;
            _subCatContext = subCatContext;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        [Display(Name = "Kategori")]
        public Category Category { get; set; }

        [BindProperty]
        [Display(Name = "Underkategori")]
        public SubCategory SubCategory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();
            _subCatContext.SubCategories.Add(SubCategory);
            await _subCatContext.SaveChangesAsync();
            

            return RedirectToPage("./Index");
        }
    }
}
