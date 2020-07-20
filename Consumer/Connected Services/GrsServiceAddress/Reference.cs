
using Tunduk;

namespace GrsAddress
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", ConfigurationName="GrsService.InfocomServicePortType")]
    public interface InfocomServicePortType
    {
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<GrsAddress.asbAddressResponse1> asbAddressAsync(GrsAddress.asbAddressRequest1 request);
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddress
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public asbAddressRequest request { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string pin { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public asbAddressResponseRequest request { get; set; }
    
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public asbAddressResponseResponse response { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponseRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string pin { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponseResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool error { get; set; }
    
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string address { get; set; }
    }
  
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public class asbAddressRequest1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsAddress.asbAddress asbAddress;
        
        public asbAddressRequest1()
        {
        }
        
        public asbAddressRequest1(XRoadClientIdentifierType client, XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsAddress.asbAddress asbAddress)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.asbAddress = asbAddress;
        }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public class asbAddressResponse1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsAddress.asbAddressResponse asbAddressResponse;
        
        public asbAddressResponse1() { }
        
        public asbAddressResponse1(XRoadClientIdentifierType client, XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsAddress.asbAddressResponse asbAddressResponse)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.asbAddressResponse = asbAddressResponse;
        }
    }
    
    public interface InfocomServicePortTypeChannel : GrsAddress.InfocomServicePortType, System.ServiceModel.IClientChannel { }
    
    public partial class InfocomServicePortTypeClient : System.ServiceModel.ClientBase<GrsAddress.InfocomServicePortType>, GrsAddress.InfocomServicePortType
    {
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InfocomServicePortTypeClient() 
        : base(InfocomServicePortTypeClient.GetDefaultBinding(), InfocomServicePortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.InfocomServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration) 
        : base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), InfocomServicePortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) 
        : base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) 
        : base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) 
        : base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GrsAddress.asbAddressResponse1> GrsAddress.InfocomServicePortType.asbAddressAsync(GrsAddress.asbAddressRequest1 request)
        {
            return base.Channel.asbAddressAsync(request);
        }

        public System.Threading.Tasks.Task<GrsAddress.asbAddressResponse1> asbAddressAsync(GrsAddress.asbAddressRequest1 request)
        {
            return ((GrsAddress.InfocomServicePortType)(this)).asbAddressAsync(request);
        }

        public System.Threading.Tasks.Task<GrsAddress.asbAddressResponse1> asbAddressAsync(XRoadClientIdentifierType client, XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsAddress.asbAddress asbAddress)
        {
            GrsAddress.asbAddressRequest1 inValue = new GrsAddress.asbAddressRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.asbAddress = asbAddress;
            return ((GrsAddress.InfocomServicePortType)(this)).asbAddressAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.InfocomServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.InfocomServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://example.org/xroad-endpoint");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InfocomServicePortTypeClient.GetBindingForEndpoint(EndpointConfiguration.InfocomServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InfocomServicePortTypeClient.GetEndpointAddress(EndpointConfiguration.InfocomServicePort);
        }
        
        public enum EndpointConfiguration
        {
            InfocomServicePort,
        }
    }
}
