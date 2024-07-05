using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvoiceApplication.Data;
using InvoiceApplication.Models;

namespace InvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersProfileController : ControllerBase
    {
        private readonly InvoiceAppContext context;

        public UsersProfileController(InvoiceAppContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserBankDetails>> GetUserBankDetails(int id)
        {
            var userProfileDetails = context.UsersProfile.FirstOrDefault(user => user.UserId==id);

            if (userProfileDetails == null)
            {
                return NotFound();
            }

            return Ok(userProfileDetails);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PutUserBankDetails(int id, UsersProfilePatchModel usersProfilePatchModel)
        {
            try
            {
                context.Database.ExecuteSqlRaw($"UPDATE UsersProfile SET UserGSTNo={usersProfilePatchModel.UserGSTNo}, UserAddress={usersProfilePatchModel.UserAddress} WHERE ProfileId = {id};");
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<UsersProfile>> PostUsersProfile(UsersProfile usersProfile)
        {
            context.UsersProfile.Add(usersProfile);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUsersProfile", new { id = usersProfile.ProfileId }, usersProfile);
        }
    }
}
