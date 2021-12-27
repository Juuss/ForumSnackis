using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snackis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public DownloadController(SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<object>> DownloadThread(int id)
        {
            var thread = await _context.Posts.FindAsync(id);
            var subCat = await _context.SubCategories.FindAsync(thread.SubCategoryId);
            var category = await _context.Categories.FindAsync(thread.CategoryId);
            var subThread = _context.Posts.Where(m => m.AnswerTo == thread.Id);
            var result = new
            {
                categoryName = category.CategoryName,
                subCategoryName = subCat.SubCatName,
                title = thread.Title,
                postedOn = thread.PostedOn,
                userName = thread.UserName,
                postText = thread.PostText,
                replies = subThread.Select(st => new {
                    postedOn = st.PostedOn,
                    userName = st.UserName,
                    postText = st.PostText,
                })
            };
            return result;
        }
    }
}
