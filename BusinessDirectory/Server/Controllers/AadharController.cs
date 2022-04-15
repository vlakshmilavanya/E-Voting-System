using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AadharController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AadharController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<AadharAuth>> GetAadharDetails(string name)
        {
            var aadhar = await _context.AadharAuth.
                FirstOrDefaultAsync(x => x.AadharNumber == name);
            if (aadhar == null)
            {
                return NotFound("User not found!");
            }
            return Ok(aadhar);
        }

        [HttpGet("Number/{name}")]
        public async Task<ActionResult<bool>> GetAadharByNumber(string name)
        {
            // reading related data

            List<AadharAuth> list = await _context.AadharAuth.ToListAsync();
            bool has = list.Any(s => s.AadharNumber == name);
            return has;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AadharAuth>> UpdateAadhar(AadharModel aadharModel)
        {
            try
            {
                var aadhar = await _context.AadharAuth.
                FirstOrDefaultAsync(x => x.AadharId == aadharModel.AadharId);

                aadhar.AadharNumber = aadharModel.AadharNumber;
                aadhar.VoterId = aadharModel.VoterId;
                aadhar.Age = aadharModel.Age;
                aadhar.IsActive = aadharModel.IsActive;
                _context.AadharAuth.Update(aadhar);
                await _context.SaveChangesAsync();
                return Ok(aadhar);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }

    }
}
