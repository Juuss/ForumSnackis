using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Snackis.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snackis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarController : ControllerBase
    {
        private readonly UserManager<SnackisUser> _userManager;

        public AvatarController(UserManager<SnackisUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetImage(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return File(user.Avatar, "image/jpg");
        }
    }
}
