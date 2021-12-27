using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Posts
{
    public class ReadPostModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public ReadPostModel(Snackis.Data.SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Post> PostList { get;set; }
        public Category Category { get; set; }
        public List<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<SubCategory> SubCategoryList { get; set; }
        [BindProperty]
        public Post Post { get; set; }

        [BindProperty]
        public Post NewPost { get; set; }
        [BindProperty]
        public string UserName { get; set; }
        public bool isUser { get; set; }
        public bool isAdmin { get; set; }
        public bool isMod { get; set; }
        public SnackisUser CurrentUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            PostList = await _context.Posts.ToListAsync();
            CategoryList = await _context.Categories.ToListAsync();
            SubCategoryList = await _context.SubCategories.ToListAsync();

            if (id == null)
            {
                return Page();
            }

            Post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);

            if (Post == null)
            {
                return Page();
            }

            NewPost = new Post { PostedOn = DateTime.Now, CategoryId = Post.CategoryId, SubCategoryId = Post.SubCategoryId, AnswerTo = Post.Id};
            CurrentUser = await _userManager.GetUserAsync(User);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(NewPost);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { id = Post.Id});
        }
    }
}
