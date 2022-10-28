using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public UserController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager,
            IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [Route("register")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            string username = user.EmailAdress;
            string password = user.Password;

            IdentityUser identityUser = new()
            {
                Email = username,
                UserName = username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(identityUser, password);

            if (identityResult.Succeeded == true)
            {
                return Ok(new { identityResult.Succeeded });
            }

            else
            {
                string errorToReturn = "Register failed with the following errors";

                foreach (var error in identityResult.Errors)
                {
                    errorToReturn += Environment.NewLine;
                    errorToReturn += $"Error code : {error.Code} - {error.Description} ";
                }

                return StatusCode(StatusCodes.Status500InternalServerError, errorToReturn);
            }

        }
        [Route("signin")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] User user)
        {
            string username = user.EmailAdress;
            string password = user.Password;

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(username, password, false, false);
            if (signInResult.Succeeded == true)
            {
                IdentityUser identityUser = await _userManager.FindByNameAsync(username);
                string JSONWebTokenString = await GenerateJSONWebToken(identityUser);
                return Ok(JSONWebTokenString);
            }
            else
            {
                return Unauthorized(user);
            }
        }

        [NonAction]
        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<string> GenerateJSONWebToken(IdentityUser identityUser)
        {
            SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            SigningCredentials credentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new()
        {
                new Claim(JwtRegisteredClaimNames.Sub, identityUser.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, identityUser.Id)

            };

        IList<string> roleNames = await _userManager.GetRolesAsync(identityUser);
        claims.AddRange(roleNames.Select(roleName => new Claim(ClaimsIdentity.DefaultRoleClaimType, roleName)));

        JwtSecurityToken jwtSecurityToken = new        (
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Issuer"],
            claims,
            null,
            expires: DateTime.UtcNow.AddDays(28),
            signingCredentials: credentials

        );

        return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }
    }


