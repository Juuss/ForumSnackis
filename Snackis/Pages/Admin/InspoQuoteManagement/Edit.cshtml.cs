using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Snackis.Data;
using Snackis.Models;

namespace Snackis.Pages.Admin.InspoQuoteManagement
{
    public class EditModel : PageModel
    {
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public EditModel(IInspoQuoteGateway gateway)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _gateway.PutInspoQuote(InspoQuote.Id, InspoQuote);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspoQuoteExists(InspoQuote.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InspoQuoteExists(long id)
        {
            return _gateway.GetInspoQuote(id) != null;
        }
    }
}
