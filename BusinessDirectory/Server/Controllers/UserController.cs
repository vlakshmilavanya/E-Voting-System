using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.Include(x => x.Address).ThenInclude(x => x.Country).Include(x => x.Address).ThenInclude(x => x.State).
                FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return NotFound("User not found!");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(ProfileModel profileModel)
        {
            try
            {
                var user = await _context.Users.Include(x => x.Address).ThenInclude(x => x.Country).
                FirstOrDefaultAsync(x => x.UserId == profileModel.UserId);

                user.FirstName = profileModel.FirstName;
                user.LastName = profileModel.LastName;
                user.EmailAddress = profileModel.EmailAddress;
                user.MobileNumber = profileModel.MobileNumber;
                user.AddressID = profileModel.AddressID;
                user.IsVoter = false;
                user.IsCandidate = false;
                user.numberOfVotes = profileModel.numberOfVotes;  
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }

    }
}
