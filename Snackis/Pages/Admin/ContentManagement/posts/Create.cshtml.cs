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
        private readonly SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public CreateModel(SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
            SubCategories = _context.SubCategories.ToList();
            Categories = _context.Categories.ToList();

            return Page();
        }

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
