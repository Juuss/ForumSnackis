using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Data;

namespace Snackis.Pages.Admin.ContentManagement.posts
{
    public class IndexModel : PageModel
    {
        private readonly Snackis.Data.PostsDBContext _context;

        public IndexModel(Snackis.Data.PostsDBContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Posts.ToListAsync();
        }
    }
}
