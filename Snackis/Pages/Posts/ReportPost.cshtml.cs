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
    public class ReportPostModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public ReportPostModel(Snackis.Data.SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Post> PostList { get; set; }
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
        [BindProperty]
        public int BacktoThread { get; set; }

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

            Report = new Report { ReportTime = DateTime.Now, ReportedBy = _userManager.GetUserId(User), PostId = Post.Id };

            if(Post.AnswerTo == 0)
            {
                BacktoThread = Post.Id;
            }
            else
            {
                BacktoThread = Post.AnswerTo;
            }

            return Page();
        }

            [BindProperty]
        public Report Report { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reports.Add(Report);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { id = Post.Id });
        }
    }
}
