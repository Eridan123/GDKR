namespace GrsForeign
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", ConfigurationName="GrsForeign.InfocomServicePortType")]
    public interface InfocomServicePortType
    {
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<GrsForeign.foreignByDocResponse1> foreignByDocAsync(GrsForeign.foreignByDocRequest1 request);
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadClientIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadLocalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadGlobalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityServerIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadCentralServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityCategoryIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadClientIdentifierType))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadIdentifierType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string xRoadInstance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string memberClass { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string memberCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string subsystemCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string groupCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string serviceCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string serviceVersion { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string securityCategoryCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string serverCode { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public XRoadObjectType objectType { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public enum XRoadObjectType
    {
        MEMBER,
        SUBSYSTEM,
        SERVER,
        GLOBALGROUP,
        LOCALGROUP,
        SECURITYCATEGORY,
        SERVICE,
        CENTRALSERVICE,
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadLocalGroupIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadGlobalGroupIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadSecurityServerIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadCentralServiceIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadSecurityCategoryIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadServiceIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDoc
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public foreignByDocRequest request { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDocRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string doc { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string code { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDocResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public foreignByDocResponseRequest request { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public foreignByDocResponseResponse response { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDocResponseRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string doc { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string code { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDocResponseResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool error { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public foreignByDocResponseResponseMessage message { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class foreignByDocResponseResponseMessage
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string surname { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string patronymic { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime birthdate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int gender { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string citizenship { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime docDateIssue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime docDateExpiration { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=8)]
        public System.Nullable<System.DateTime> regDateFrom { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=9)]
        public System.Nullable<System.DateTime> regDateTo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string regAddress { get; set; }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class foreignByDocRequest1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsForeign.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsForeign.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsForeign.foreignByDoc foreignByDoc;
        
        public foreignByDocRequest1() { }
        
        public foreignByDocRequest1(GrsForeign.XRoadClientIdentifierType client, GrsForeign.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsForeign.foreignByDoc foreignByDoc)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.foreignByDoc = foreignByDoc;
        }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class foreignByDocResponse1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsForeign.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsForeign.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsForeign.foreignByDocResponse foreignByDocResponse;
        
        public foreignByDocResponse1() { }
        
        public foreignByDocResponse1(GrsForeign.XRoadClientIdentifierType client, GrsForeign.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsForeign.foreignByDocResponse foreignByDocResponse)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.foreignByDocResponse = foreignByDocResponse;
        }
    }
    
    public interface InfocomServicePortTypeChannel : GrsForeign.InfocomServicePortType, System.ServiceModel.IClientChannel { }
    
    public partial class InfocomServicePortTypeClient : System.ServiceModel.ClientBase<GrsForeign.InfocomServicePortType>, GrsForeign.InfocomServicePortType
    {
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InfocomServicePortTypeClient() : base(InfocomServicePortTypeClient.GetDefaultBinding(), InfocomServicePortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.InfocomServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), InfocomServicePortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InfocomServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InfocomServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GrsForeign.foreignByDocResponse1> GrsForeign.InfocomServicePortType.foreignByDocAsync(GrsForeign.foreignByDocRequest1 request)
        {
            return base.Channel.foreignByDocAsync(request);
        }
        
        public System.Threading.Tasks.Task<GrsForeign.foreignByDocResponse1> foreignByDocAsync(GrsForeign.XRoadClientIdentifierType client, GrsForeign.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsForeign.foreignByDoc foreignByDoc)
        {
            GrsForeign.foreignByDocRequest1 inValue = new GrsForeign.foreignByDocRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.foreignByDoc = foreignByDoc;
            return ((GrsForeign.InfocomServicePortType)(this)).foreignByDocAsync(inValue);
        }

        public System.Threading.Tasks.Task<GrsForeign.foreignByDocResponse1> foreignByDocAsync(GrsForeign.foreignByDocRequest1 inValue)
        {
            return ((GrsForeign.InfocomServicePortType)(this)).foreignByDocAsync(inValue);
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
