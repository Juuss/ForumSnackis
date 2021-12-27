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
        private readonly Snackis.Data.PostsDBContext _topicsContext;
        private readonly Snackis.Data.SubCatDBContext _subCatContext;

        public TopicsIndexModel(Snackis.Data.PostsDBContext topicsContext, Snackis.Data.SubCatDBContext subCatContext)
        {
            _topicsContext = topicsContext;
            _subCatContext = subCatContext;
        }

        public IList<Post> PostList { get;set; }
        public Post Post { get; set; }

        public IList<SubCategory> SubCategoryList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            SubCategoryList = await _subCatContext.SubCategories.ToListAsync();
            PostList = await _topicsContext.Posts.ToListAsync();

            if (id == null)
            {
                return Page();
            }

            Post = await _topicsContext.Posts.FirstOrDefaultAsync(m => m.SubCategoryId == id);

            if (Post == null)
            {
                return Page();
            }
            return Page();
        }
    }
}
