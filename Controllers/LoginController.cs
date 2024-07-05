using InvoiceApplication.Data;
using InvoiceApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly InvoiceAppContext context;
        public readonly IConfiguration configuration;
        public LoginController(InvoiceAppContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginModel loginDetails)
        {
            try
            {
                var userDetails = CheckUser(loginDetails);
                if (userDetails != null)
                {
                    string token = GenrateToken(userDetails.UserId);
                    return Ok(new { userId = userDetails.UserId, token });
                }
                else
                {
                    return NotFound("User Not found");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        private UsersList CheckUser(LoginModel loginDetails)
        {
            return context.UsersList.FirstOrDefault(user => (user.UserEmail == loginDetails.Email && user.UserPassword == loginDetails.Password) || (user.UserPhone == loginDetails.Phone && user.UserPassword == loginDetails.Password));
        }

        private string GenrateToken(int userId)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, $"{userId}")
            };

            var Sectoken = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: credentials
                );

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return token;
        }
    }

}