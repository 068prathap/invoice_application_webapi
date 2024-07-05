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
    public class UserBankDetailsController : ControllerBase
    {
        private readonly InvoiceAppContext context;

        public UserBankDetailsController(InvoiceAppContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserBankDetails>> GetUserBankDetails(int id)
        {
            var userBankDetails = await context.UserBankDetails.FindAsync(id);

            if (userBankDetails == null)
            {
                return NotFound();
            }

            return userBankDetails;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserBankDetails(int id, UserBankDetails userBankDetails)
        {
            if (id != userBankDetails.BankDetailsId)
            {
                return BadRequest();
            }

            context.Entry(userBankDetails).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserBankDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<UserBankDetails>> PostUserBankDetails(UserBankDetails userBankDetails)
        {
            context.UserBankDetails.Add(userBankDetails);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUserBankDetails", new { id = userBankDetails.BankDetailsId }, userBankDetails);
        }

        private bool UserBankDetailsExists(int id)
        {
            return context.UserBankDetails.Any(e => e.BankDetailsId == id);
        }
    }
}
