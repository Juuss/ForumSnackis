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
    public class IndexModel : PageModel
    {
        private readonly Snackis.Models.IInspoQuoteGateway _gateway;

        public IndexModel(IInspoQuoteGateway gateway)
        {
            _gateway = gateway;
        }

        public IList<InspoQuote> InspoQuote { get;set; }

        public async Task OnGetAsync()
        {
            InspoQuote = await _gateway.GetInspoQuote();
        }
    }
}
