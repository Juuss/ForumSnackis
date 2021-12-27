using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.ContentManagement.posts
{
    public class CreateModel : PageModel
    {
        private readonly Snackis.Data.PostsDBContext _context;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;
        private readonly Snackis.Data.CategoriesDBContext _catContext;
        private readonly UserManager<SnackisUser> _userManager;

        public CreateModel(Snackis.Data.PostsDBContext context, Snackis.Data.SubCatDBContext subCatContext, UserManager<SnackisUser> userManager, Snackis.Data.CategoriesDBContext catContext)
        {
            _context = context;
            _subCatContext = subCatContext;
            _userManager = userManager;
            _catContext = catContext;
        }

        public SubCategory SubCategory { get; set; }
        public Category Category { get; set; }

        [BindProperty]
        public string UserID { get; set; }
        [BindProperty]
        public List<SubCategory> SubCategories { get; set; }
        public List<Category> Categories { get; set; }

        [BindProperty]
        public Post Post { get; set; }

        public IActionResult OnGet()
        {
            Post = new Post { PostedOn = DateTime.Now};
            SubCategories = _subCatContext.SubCategories.ToList();
            Categories = _catContext.Categories.ToList();

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
