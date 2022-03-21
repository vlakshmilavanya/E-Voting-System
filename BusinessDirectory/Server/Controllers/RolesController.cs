using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace BusinessDirectory.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public RolesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("all")]
        public async Task<List<Roles>> GetAllRoles()
        {
            return await dbContext.Roles.Include(e => e.RoleType).Include(e => e.User).ToListAsync();
        }

        [HttpGet("roletypes")]
        public async Task<List<RoleType>> GetAllRoleTypes()
        {
            return await dbContext.RoleType.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Roles>> UpdateRole(RolesModel model)
        {
            try
            {
                var roles = await dbContext.Roles.FirstOrDefaultAsync(x => x.RoleID == model.RoleID);
                roles.RoleTypeID = model.RoleTypeID;
                roles.IsActive = model.IsActive;
                dbContext.Roles.Update(roles);
                await dbContext.SaveChangesAsync();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            try
            {
                var role = await dbContext.Roles.FindAsync(id);
                dbContext.Roles.Remove(role);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpPost]
        public async Task<ActionResult<Roles>> AddRole(RolesModel model)
        {
            try
            {
                Roles role = new Roles()
                {
                    UserID = model.UserID,
                    RoleTypeID = model.RoleTypeID,
                    IsActive = model.IsActive,
                    CreatedBy = model.CreatedBy,
                    RolesTimestamp = DateTime.Now
                };
                dbContext.Roles.Add(role);
                await dbContext.SaveChangesAsync();
                return Ok(role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating record");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            // reading related data
            Roles role = await dbContext.Roles.Include(s => s.RoleType).Include(s => s.User).FirstOrDefaultAsync(s => s.RoleID == id);
            if (role == null)
            {
                return NotFound("Not Found");
            }
            else
            {
                return Ok(role);
            }
        }

        [HttpGet("User/{id:int}")]
        public async Task<List<Roles>> GetRoleByUserId(int id)
        {
            // reading related data
            return await dbContext.Roles.Include(s => s.RoleType).Include(s => s.User).Where(s => s.UserID == id).ToListAsync();
        }

    }
}
