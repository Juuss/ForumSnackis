using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.InspoQuoteManagement
{
    public class CreateModel : PageModel
    {
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public CreateModel(IInspoQuoteGateway gateway)
        {
            _gateway = gateway;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InspoQuote InspoQuote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _gateway.PostInspoQuote(InspoQuote);

            return RedirectToPage("./Index");
        }
    }
}
