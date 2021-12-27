using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Posts
{
    public class PostsViewModel : PageModel
    {
        private readonly Snackis.Data.CategoriesDBContext _context;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;
        private readonly Snackis.Data.PostsDBContext _postsContext;
        public IList<Category> Categories { get; set; }
        public IList<SubCategory> SubCategories { get; set; }
        public IList<Post> Posts { get; set; }

        public Category Category { get; set; }
        public Post Post { get; set; }
        public Post PostID { get; set; }
        public SubCategory SubCategory { get; set; }
        public PostsViewModel(Snackis.Data.CategoriesDBContext context, Snackis.Data.SubCatDBContext subCatContext, Snackis.Data.PostsDBContext postsContext)
        {
            _context = context;
            _subCatContext = subCatContext;
            _postsContext = postsContext;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Categories = await _context.Categories.ToListAsync();
            SubCategories = await _subCatContext.SubCategories.ToListAsync();
            Posts = await _postsContext.Posts.ToListAsync();

            if (id == null)
            {
                return Page();
            }

            PostID = await _postsContext.Posts.FirstOrDefaultAsync(m => m.Id == id);

            if (SubCategory == null)
            {
                return Page();
            }
            return Page();
        }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
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
