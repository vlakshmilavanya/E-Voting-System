using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BusinessDirectory.Server.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<string>> Login(string email)
        {
            var response = new ServiceResponse<string>();
            var user = await _context.Users.FirstOrDefaultAsync(user => user.EmailAddress.ToLower().Equals(email.ToLower()));
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found.";
            }
            else
            {
                response.Data = CreateToken(user);
            }

            return response;
        }

        public async Task<ServiceResponse<int>> Register(User user)
        {
            if (await UserExists(user.EmailAddress))
            {
                return new ServiceResponse<int> { Success = false, Message = "User already exists." };
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var userRoleType = await _context.RoleType.FirstOrDefaultAsync(s => s.RoleTitle.Equals("User"));
            if (userRoleType != null)
            {
                _context.Roles.Add(new Roles { UserID = user.UserId, RoleTypeID = userRoleType.RoleTypeId });
                await _context.SaveChangesAsync();
            }

            return new ServiceResponse<int> { Data = user.UserId, Message = "Registration successful!" };
        }

        public async Task<bool> UserExists(string email)
        {
            if (await _context.Users.AnyAsync(user => user.EmailAddress.ToLower().Equals(email.ToLower())))
            {
                return true;
            }
            return false;
        }

        private string CreateToken(User user)
        {

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.FirstName)
            };

            var userRole = _context.Roles.Include(r => r.RoleType).FirstOrDefault(s => s.UserID == user.UserId);
            if (userRole != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, $"{userRole.RoleType.RoleTitle}"));
            }

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

    }
}
