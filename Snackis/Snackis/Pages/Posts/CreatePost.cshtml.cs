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

namespace Snackis.Pages.Posts
{
    public class CreatePostModel : PageModel
    {
        private readonly Snackis.Data.PostsDBContext _topicsContext;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;
        private readonly Snackis.Data.CategoriesDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public CreatePostModel(Snackis.Data.PostsDBContext topicsContext, Snackis.Data.SubCatDBContext subCatContext, Snackis.Data.CategoriesDBContext context, UserManager<SnackisUser> userManager)
        {
            _topicsContext = topicsContext;
            _subCatContext = subCatContext;
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Post Post { get; set; }
        public SubCategory SubCategory { get; set; }
        [BindProperty]
        public string UserName { get; set; }
        public IList<SubCategory> SubCategoryList { get; set; }
        public IList<Category> CategoryList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            SubCategoryList = await _subCatContext.SubCategories.ToListAsync();
            CategoryList = await _context.Categories.ToListAsync();

            if (id == null)
            {
                return Page();
            }

            SubCategory = await _subCatContext.SubCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (SubCategory == null)
            {
                return Page();
            }
            Post = new Post { PostedOn = DateTime.Now, CategoryId = SubCategory.CategoryID, SubCategoryId = SubCategory.Id };
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _topicsContext.Posts.Add(Post);
            await _topicsContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
