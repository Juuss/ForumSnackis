using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snackis.Areas.Identity.Data;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Chat
{
    public class SendMessageModel : PageModel
    {
        private readonly Snackis.Data.SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public SendMessageModel(Snackis.Data.SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [BindProperty]
        public ChattMessage ChattMessage { get; set; }
        public string RecipientUserName { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return Page();
            }

            var recipient = await _userManager.FindByIdAsync(id);
            RecipientUserName = recipient.UserName;

            ChattMessage = new ChattMessage { SenderId = _userManager.GetUserId(User), RecipientId = recipient.Id};
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ChattMessage.SentTime = DateTime.Now;
            _context.ChattMessages.Add(ChattMessage);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { id = ChattMessage.RecipientId});
        }
    }
}
