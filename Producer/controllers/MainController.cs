using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gkdr.Producer.contracts;
using Gkdr.Producer.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Producer.controllers
{
    [Route("api/")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MainController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        [Route("GetOrganizations")]
        public Task<List<CustomResponse>> GetAddressByPinAsync([FromBody] string name) //[FromBody] string pin
        {
            return _context.Organizations
                .AsNoTracking()
                .Where(p => p.Name.Contains(name))                
                .Select(s => new CustomResponse()
                {
                    Name = s.Name,
                    Licence = s.CertificateNumber,
                    RegistrationDate = s.RegistrationDate,
                    Phone = s.Phone,
                    WebSite = s.WebSite,
                    Email = s.Email,
                    Forbidden = s.Forbidden == 1,
                    District = s.IdCityNavigation.IdDistinctNavigation.Name,
                    Region = s.IdCityNavigation.IdDistinctNavigation.IdRegionNavigation.Name,
                    City = s.IdCityNavigation.Name,
                    Address = s.Address,
                    Religion = s.IdSubReligionNavigation.IdReligionNavigation.Name,
                    SubReligion = s.IdSubReligionNavigation.Name,
                })
                .ToListAsync();
        }

    }
}