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
    public class AddressController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{Id:int}")]
        public async Task<Address> GetAddressById(int Id)
        {
            var res = await _context.Address.FirstOrDefaultAsync(b => b.AddressID == Id);
            if (res != null)
                return res;
            else
                return new Address();
        }

        [HttpPost]
        public async Task<Address> AddAddress(Address address)
        {
            try
            {
                address.CountryId = 0;
                _context.Address.Add(address);
                await _context.SaveChangesAsync();
                return address;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Getting cities from users registered so far
        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
        {
            return Ok(await _context.Address.Select(x => new { x.City }).ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<Address>> UpdateAddress(BusinessFormModel model)
        {
            try
            {
                var response = await _context.Address.FirstOrDefaultAsync(b => b.AddressID == model.AddressID);
                response.Pincode = model.Pincode;
                response.StateId = model.StateId;
                response.Landmark = model.Landmark;
                response.Street = model.Street;
                response.City = model.City;
                response.Building = model.Building;
                response.Area = model.Area;
                _context.Address.Update(response);
                await _context.SaveChangesAsync();
                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
