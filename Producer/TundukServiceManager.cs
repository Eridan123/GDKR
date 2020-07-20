using System.Reflection;
using XRoadLib;
using XRoadLib.Attributes;
using XRoadLib.Headers;
using XRoadLib.Schema;

namespace Gkdr.Producer
{
    public class TundukServiceManager : ServiceManager<XRoadHeader40>
    {
        public TundukServiceManager()
            : base("4.0", new DefaultSchemaExporter("http://producer.xroad.com",
                typeof(TundukServiceManager).GetTypeInfo().Assembly))
        {
            /*
            ProtocolDefinition.ServiceName = "GdkrService";
            ProtocolDefinition.SoapAddressLocation = "http://example.org/xroad-endpoint";
            ProtocolDefinition.BindingName = "GdkrServiceBinding";
            ProtocolDefinition.PortName = "GdkrServicePort";
            */
        }
    }
}
