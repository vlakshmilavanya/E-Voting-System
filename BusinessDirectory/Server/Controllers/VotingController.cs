using BusinessDirectory.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotingController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public VotingController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet("{id:int}")]
        public async Task<List<Roles>> GetRolesByRole(int id)
        {
            // reading related data
            return await dbContext.Roles.Include(s => s.RoleType).Include(s => s.User).Where(s => s.RoleTypeID == id).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Vote>> AddRole(VoteModel model)
        {
            try
            {
                var response = await dbContext.Vote.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (response != null)
                {
                    response.IsActive = false;
                    return Ok(response);
                }
                Vote vote = new Vote()
                {
                    Id = model.Id,
                    UserId = model.UserID,
                    IsActive = model.IsActive,
                };
                dbContext.Vote.Add(vote);
                await dbContext.SaveChangesAsync();
                return Ok(vote);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating record");
            }
        }

        [HttpGet("Id/{id:int}")]
        public async Task<ActionResult<bool>> CheckId(int id)
        {
            if (dbContext.Vote.Count((a) => a.Id == id) == 0)
                return true;
            else
                return false;
            // reading related data
        }
    }
}
