using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis;
using Snackis.Areas.Identity.Data;
using Snackis.Data;

namespace Snackis.Pages.Admin.ContentManagement
{
    public class ReportedPostsModel : PageModel
    {
        private readonly SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public ReportedPostsModel(SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Report> Report { get;set; }
        public List<Post> TopicsList { get; set; }
        public List<SnackisUser> UserList{ get; set; }

        public async Task OnGetAsync()
        {
            UserList = await _userManager.Users.ToListAsync();
            Report = await _context.Reports.ToListAsync();
            TopicsList = await _context.Posts.ToListAsync();
        }
    }
}
