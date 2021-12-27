using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Data;

namespace Snackis.Pages.Posts
{
    public class TopicsIndexModel : PageModel
    {
        private readonly SnackisDBContext _context;
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public TopicsIndexModel(SnackisDBContext context)
        {
            _context = context;
        }

        public IList<Post> PostList { get;set; }
        public Post Post { get; set; }

        public SubCategory SubCategory { get; set; }

        public IList<SubCategory> SubCategoryList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            SubCategoryList = await _context.SubCategories.ToListAsync();
            PostList = await _context.Posts.ToListAsync();
            
            if (id == null)
            {
                return Page();
            }

            Post = await _context.Posts.FirstOrDefaultAsync(m => m.SubCategoryId == id);
            SubCategory = SubCategoryList.FirstOrDefault(m => m.Id == id);

            if (Post == null)
            {
                return Page();
            }
            
            return Page();
        }
    }
}
