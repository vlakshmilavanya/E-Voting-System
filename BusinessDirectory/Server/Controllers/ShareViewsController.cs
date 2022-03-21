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
    public class ShareViewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShareViewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<List<ShareYourViews>> GetViews()
        {
            return await _context.ShareYourViews.Include(e => e.User).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetViewById(int id)
        {
            var view = await _context.ShareYourViews.Include(e => e.User).FirstOrDefaultAsync(x => x.ShareYourViewsId == id);
            if (view == null)
            {
                return NotFound("View not found!");
            }
            return Ok(view);
        }

        [HttpPost]
        public async Task<ActionResult<ShareYourViews>> AddQuery(ShareViewsModel shareViewsModel)
        {
            try
            {
                ShareYourViews views = new ShareYourViews()
                {
                    View = shareViewsModel.View,
                    UserId = shareViewsModel.UserId,
                    ViewsTimestamp = DateTime.Now
                };
                _context.ShareYourViews.Add(views);
                await _context.SaveChangesAsync();
                return Ok(views);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }


    }
}
