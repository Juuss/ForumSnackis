using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Snackis.Areas.Identity.Data;

namespace Snackis.Pages.Admin
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string AddUserId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string RemoveUserId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Role { get; set; }
        public SnackisUser CurrentUser { get; set; }

        [BindProperty]
        public string RoleName { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public bool isUser { get; set; }
        public bool isAdmin { get; set; }
        public bool isMod { get; set; }
        public IQueryable<SnackisUser> Users { get; set; }

        private readonly RoleManager<IdentityRole> _roleManager;
        public UserManager<SnackisUser> _userManager;

        public IndexModel(RoleManager<IdentityRole> roleManager, UserManager<SnackisUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Roles = _roleManager.Roles.ToList();
            Users = _userManager.Users;

            if(AddUserId != null)
            {
                var alterUser = await _userManager.FindByIdAsync(AddUserId);
                var roleResult = await _userManager.AddToRoleAsync(alterUser, Role);
            }

            if (RemoveUserId != null)
            {
                var alterUser = await _userManager.FindByIdAsync(RemoveUserId);
                var roleResult = await _userManager.RemoveFromRoleAsync(alterUser, Role);
            }

            CurrentUser = await _userManager.GetUserAsync(User);
            isUser = await _userManager.IsInRoleAsync(CurrentUser, "User");
            isMod = await _userManager.IsInRoleAsync(CurrentUser, "Mod");
            isAdmin = await _userManager.IsInRoleAsync(CurrentUser, "Admin");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(RoleName != null)
            {
                await CreateRole(RoleName);
            }
            return RedirectToPage("./index");
        }

        public async Task CreateRole(string roleName)
        {
            bool exist = await _roleManager.RoleExistsAsync(roleName);
            if (!exist)
            {
                var role = new IdentityRole
                {
                    Name = roleName
                };

                await _roleManager.CreateAsync(role);
            }
        }
    }
}
