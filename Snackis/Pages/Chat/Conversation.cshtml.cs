using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Chat
{
    public class ConversationModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public ConversationModel(Snackis.Data.SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<ChattMessage> ChattMessage { get; set; }
        public List<SnackisUser> UserList { get; set; }
        public SnackisUser ConversationWith { get; set; }

        public async Task OnGetAsync(string id)
        {
            var message = await _context.ChattMessages.ToListAsync();
            var UserId = _userManager.GetUserId(User);
            ChattMessage = message.Where(m => (m.RecipientId == UserId && m.SenderId == id) || (m.SenderId == UserId && m.RecipientId == id)).OrderByDescending(m => m.SentTime).ToList();
            UserList = await _userManager.Users.ToListAsync();
            ConversationWith = await _userManager.FindByIdAsync(id);
        }
    }
}
