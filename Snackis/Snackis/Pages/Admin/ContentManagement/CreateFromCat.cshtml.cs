using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Snackis.Models;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;


namespace Snackis.Pages.Admin.ContentManagement
{
    public class CreateFromCatModel : PageModel
    {
        private readonly Snackis.Data.CategoriesDBContext _context;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;

        public CreateFromCatModel(Snackis.Data.CategoriesDBContext context, Snackis.Data.SubCatDBContext subCatContext)
        {
            _context = context;
            _subCatContext = subCatContext;
        }

        [BindProperty]
        [Display(Name = "Kategori")]
        public Category Category { get; set; }


        [BindProperty]
        [Display(Name = "Underkategori")]
        public SubCategory SubCategory { get; set; }
        public int CatID { get; set; }

        [DataType(DataType.Text)]
        public int subCatId { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _subCatContext.Add(SubCategory);
            await _subCatContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
