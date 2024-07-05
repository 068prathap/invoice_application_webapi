using InvoiceApplication.Data;
using InvoiceApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public readonly InvoiceAppContext context;
        public RegisterController(InvoiceAppContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Register(UsersList usersList)
        {
            try
            {
                if (!CheckUser(usersList.UserEmail, usersList.UserPhone))
                {
                    context.UsersList.AddAsync(usersList);
                    await context.SaveChangesAsync();
                    return StatusCode(201, "Successfully Registered");
                }
                else
                {
                    return Conflict("User already exist");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        private bool CheckUser(string UserEmail, string UserPhone)
        {
            return context.UsersList.Any(user => (user.UserPhone == UserPhone || user.UserEmail == UserEmail));
        }
    }
}
