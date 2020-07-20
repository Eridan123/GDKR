using System;
using Gkdr.Producer.contracts;
using XRoadLib.Attributes;

namespace Gkdr.Producer.services
{
    public interface IGkdrSoapService : IDisposable
    {
        [XRoadService("GetOrganizations", AddedInVersion = 1)]
        [XRoadTitle("ru", "Поиск организации по названию")]
        CustomResponse[] GetOrganizations(string name);
    }
    
    public class GkdrSoapService : IGkdrSoapService
    {
        private readonly IGkdrService _service;
        
        public GkdrSoapService(IGkdrService service)
        {
            _service = service;
        }
        
        public CustomResponse[] GetOrganizations(string name)
        {
            return _service.GetOrganizations(name);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}