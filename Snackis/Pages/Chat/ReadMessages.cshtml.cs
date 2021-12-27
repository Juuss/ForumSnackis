using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Areas.Identity.Data;
using Snackis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snackis.Pages.Chat
{
    public class ReadMessagesModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;
        private readonly SignInManager<SnackisUser> _signInManager;

        public ReadMessagesModel(Snackis.Data.SnackisDBContext context, UserManager<SnackisUser> userManager, SignInManager<SnackisUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IList<Conversation> Conversations { get;set; }

        public async Task OnGetAsync()
        {
            var Messages = await _context.ChattMessages.ToListAsync();
            var UserId = _userManager.GetUserId(User);
            var MyMessages = Messages.Where(m => m.RecipientId == UserId || m.SenderId == UserId);
            var AllConversations = MyMessages.GroupBy(m => m.RecipientId == UserId ? m.SenderId : m.RecipientId);
            Conversations = AllConversations.Select(c => new Conversation { UserId = c.Key, LatestMessageDate = c.Max(m => m.SentTime)}).ToList();
            foreach( var conv in Conversations)
            {
                conv.UserName = (await _userManager.FindByIdAsync(conv.UserId)).UserName;
            }
        }
    }
    public class Conversation
    {
        public string UserName { get; set; }
        public DateTime LatestMessageDate { get; set; }
        public string UserId { get; set; }
    }

}
