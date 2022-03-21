using BusinessDirectory.Client.Services;
using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController
    {
        private readonly ApplicationDbContext _context;

        public StateController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<State> GetStateByName(string name)
        {
            var state = await _context.State.FirstOrDefaultAsync(s => s.StateName == name);
            if (state == null)
            {

            }
            return state;
        }
        [HttpGet("{Id:int}")]
        public async Task<State> GetStateById(int Id)
        {
            var state = await _context.State.FirstOrDefaultAsync(s => s.StateId == Id);

            return state;
        }

        [HttpPost("Profile")]
        public async Task<State> AddProfileState(ProfileModel model)
        {
            try
            {
                var sampleState = await _context.State.FirstOrDefaultAsync(s => s.StateName == model.StateName);
                if (sampleState == null)
                {
                    State state = new State()
                    {
                        StateName = model.StateName,
                        StateTimestamp = DateTime.Now,

                    };
                    _context.State.Add(state);
                    await _context.SaveChangesAsync();
                    return state;
                }
                return sampleState;
            }
            catch (Exception)
            {
                return null;
            }
        }
        [HttpPost]
        public async Task<State> AddState(BusinessFormModel model)
        {
            try
            {
                var sampleState = await _context.State.FirstOrDefaultAsync(s => s.StateName.ToLower() == model.StateName.ToLower());
                if (sampleState == null)
                {
                    State state = new State()
                    {
                        StateName = model.StateName,
                        StateTimestamp = DateTime.Now,

                    };
                    _context.State.Add(state);
                    await _context.SaveChangesAsync();
                    return state;
                }
                return sampleState;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
