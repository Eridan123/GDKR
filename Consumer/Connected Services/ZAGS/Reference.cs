namespace ZAGS
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", ConfigurationName="ZAGS.InfocomServicePortType")]
    public interface InfocomServicePortType
    {
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<ZAGS.zagsDataByPinResponse1> zagsDataByPinAsync(ZAGS.zagsDataByPinRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<ZAGS.zagsPinsByNSPDateResponse1> zagsPinsByNSPDateAsync(ZAGS.zagsPinsByNSPDateRequest1 request);
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
    public partial class zagsDataByPin
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public zagsDataByPinRequest request { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsDataByPinRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string pin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<bool> datetimeFormat { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsDataByPinResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public zagsDataByPinResponseRequest request { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public zagsDataByPinResponseResponse response { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsDataByPinResponseRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string pin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string datetimeFormat { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsDataByPinResponseResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string pin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime pinGenerationDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string surname { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string patronymic { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string gender { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime dateOfBirth { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string maritalStatus { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", IsNullable=true, Order=8)]
        public string maritalStatusId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string nationality { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", IsNullable=true, Order=10)]
        public string nationalityId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string citizenship { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", IsNullable=true, Order=12)]
        public string citizenshipId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string pinBlocked { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<System.DateTime> deathDate { get; set; }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zagsDataByPinRequest1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public ZAGS.zagsDataByPin zagsDataByPin;
        
        public zagsDataByPinRequest1() { }
        
        public zagsDataByPinRequest1(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsDataByPin zagsDataByPin)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.zagsDataByPin = zagsDataByPin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zagsDataByPinResponse1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public ZAGS.zagsDataByPinResponse zagsDataByPinResponse;
        
        public zagsDataByPinResponse1() { }
        
        public zagsDataByPinResponse1(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsDataByPinResponse zagsDataByPinResponse)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.zagsDataByPinResponse = zagsDataByPinResponse;
        }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsPinsByNSPDate
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public zagsPinsByNSPDateRequest request { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsPinsByNSPDateRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string surname { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string patronymic { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime birthdate { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsPinsByNSPDateResponse
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public zagsPinsByNSPDateResponseRequest request { get; set; }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("pin", IsNullable=false)]
        public string[] response { get; set; }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class zagsPinsByNSPDateResponseRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string surname { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string patronymic { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> birthdate { get; set; }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zagsPinsByNSPDateRequest1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public ZAGS.zagsPinsByNSPDate zagsPinsByNSPDate;
        
        public zagsPinsByNSPDateRequest1() { }
        
        public zagsPinsByNSPDateRequest1(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsPinsByNSPDate zagsPinsByNSPDate)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.zagsPinsByNSPDate = zagsPinsByNSPDate;
        }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zagsPinsByNSPDateResponse1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public ZAGS.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public ZAGS.zagsPinsByNSPDateResponse zagsPinsByNSPDateResponse;
        
        public zagsPinsByNSPDateResponse1() { }
        
        public zagsPinsByNSPDateResponse1(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsPinsByNSPDateResponse zagsPinsByNSPDateResponse)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.zagsPinsByNSPDateResponse = zagsPinsByNSPDateResponse;
        }
    }
    
    public interface InfocomServicePortTypeChannel : ZAGS.InfocomServicePortType, System.ServiceModel.IClientChannel { }
    
    public partial class InfocomServicePortTypeClient : System.ServiceModel.ClientBase<ZAGS.InfocomServicePortType>, ZAGS.InfocomServicePortType
    {
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InfocomServicePortTypeClient() : 
                base(InfocomServicePortTypeClient.GetDefaultBinding(), InfocomServicePortTypeClient.GetDefaultEndpointAddress())
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
        System.Threading.Tasks.Task<ZAGS.zagsDataByPinResponse1> ZAGS.InfocomServicePortType.zagsDataByPinAsync(ZAGS.zagsDataByPinRequest1 request)
        {
            return base.Channel.zagsDataByPinAsync(request);
        }
        
        public System.Threading.Tasks.Task<ZAGS.zagsDataByPinResponse1> zagsDataByPinAsync(ZAGS.zagsDataByPinRequest1 inValue)
        {
            return ((ZAGS.InfocomServicePortType)(this)).zagsDataByPinAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ZAGS.zagsDataByPinResponse1> zagsDataByPinAsync(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsDataByPin zagsDataByPin)
        {
            ZAGS.zagsDataByPinRequest1 inValue = new ZAGS.zagsDataByPinRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.zagsDataByPin = zagsDataByPin;
            return ((ZAGS.InfocomServicePortType)(this)).zagsDataByPinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ZAGS.zagsPinsByNSPDateResponse1> ZAGS.InfocomServicePortType.zagsPinsByNSPDateAsync(ZAGS.zagsPinsByNSPDateRequest1 request)
        {
            return base.Channel.zagsPinsByNSPDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ZAGS.zagsPinsByNSPDateResponse1> zagsPinsByNSPDateAsync(ZAGS.XRoadClientIdentifierType client, ZAGS.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, ZAGS.zagsPinsByNSPDate zagsPinsByNSPDate)
        {
            ZAGS.zagsPinsByNSPDateRequest1 inValue = new ZAGS.zagsPinsByNSPDateRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.zagsPinsByNSPDate = zagsPinsByNSPDate;
            return ((ZAGS.InfocomServicePortType)(this)).zagsPinsByNSPDateAsync(inValue);
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
