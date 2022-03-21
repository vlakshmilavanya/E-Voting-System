using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/Queries")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public QueriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<List<Query>> GetQueries()
        {
            return await _context.Query.Include(e => e.User).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetQueryById(int id)
        {
            var query = await _context.Query.Include(e => e.User).FirstOrDefaultAsync(x => x.QueryId == id);
            if (query == null)
            {
                return NotFound("Query not found!");
            }
            return Ok(query);
        }

        [HttpPost]
        public async Task<ActionResult<Query>> AddQuery(QueriesModel queriesModel)
        {
            try
            {
                Query query = new Query()
                {
                    QueryDescription = queriesModel.QueryDescription,
                    UserId = queriesModel.UserId,
                    QueryTimestamp = DateTime.Now
                };
                _context.Query.Add(query);
                await _context.SaveChangesAsync();
                return Ok(query);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }

    }
}
