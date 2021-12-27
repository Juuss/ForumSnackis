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

namespace Snackis.Pages.Admin
{
    public class DeleteReportModel : PageModel
    {
        private readonly SnackisDBContext _context;
        private readonly UserManager<SnackisUser> _userManager;

        public DeleteReportModel(SnackisDBContext context, UserManager<SnackisUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Report Report { get; set; }
        public SnackisUser ReportedBy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Report = await _context.Reports.FirstOrDefaultAsync(m => m.Id == id);
            ReportedBy = await _userManager.FindByIdAsync(Report.ReportedBy);

            if (Report == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Report = await _context.Reports.FindAsync(id);

            if (Report != null)
            {
                _context.Reports.Remove(Report);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
