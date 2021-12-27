using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.InspoQuoteManagement
{
    public class DeleteModel : PageModel
    {
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public DeleteModel(IInspoQuoteGateway gateway)
        {
            _gateway = gateway;
        }

        [BindProperty]
        public InspoQuote InspoQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InspoQuote = await _gateway.GetInspoQuote(id.Value);

            if (InspoQuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InspoQuote = await _gateway.GetInspoQuote(id.Value);

            if (InspoQuote != null)
            {
                await _gateway.DeleteInspoQuote(id.Value);
            }

            return RedirectToPage("./Index");
        }
    }
}
