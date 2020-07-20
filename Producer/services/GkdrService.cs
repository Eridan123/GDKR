using System;
using System.Linq;
using Gkdr.Producer.contracts;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Producer.services
{
    public interface IGkdrService : IDisposable
    {
        CustomResponse[] GetOrganizations(string name);
    }
    
    public class GkdrService : IGkdrService 
    {
        private readonly AppDbContext _context;

        public GkdrService(AppDbContext context)
        {
            _context = context;
        }

        public CustomResponse[] GetOrganizations(string name)
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
                .ToArray();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}