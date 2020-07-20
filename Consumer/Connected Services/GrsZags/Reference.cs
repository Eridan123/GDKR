namespace GrsZags
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", ConfigurationName="GrsZags.InfocomServicePortType")]
    public interface InfocomServicePortType
    {
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<GrsZags.zagsDataByPinResponse1> zagsDataByPinAsync(GrsZags.zagsDataByPinRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<GrsZags.zagsPinsByNSPDateResponse1> zagsPinsByNSPDateAsync(GrsZags.zagsPinsByNSPDateRequest1 request);
        
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
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class act
    {
        
        private string actDateField;
        
        private string actNumberField;
        
        private string actGovUnitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string actDate
        {
            get
            {
                return this.actDateField;
            }
            set
            {
                this.actDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string actNumber
        {
            get
            {
                return this.actNumberField;
            }
            set
            {
                this.actNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string actGovUnit
        {
            get
            {
                return this.actGovUnitField;
            }
            set
            {
                this.actGovUnitField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public partial class item
    {
        
        private string idField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
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
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string nationality { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string citizenship { get; set; }
        
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
        public GrsZags.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsZags.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsZags.zagsDataByPin zagsDataByPin;
        
        public zagsDataByPinRequest1() { }
        
        public zagsDataByPinRequest1(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsDataByPin zagsDataByPin)
        {
            this.id = id;
            this.userId = userId;
            this.issue = issue;
            this.protocolVersion = protocolVersion;
            this.client = client;
            this.service = service;
            this.zagsDataByPin = zagsDataByPin;
        }
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zagsDataByPinResponse1
    {
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsZags.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsZags.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsZags.zagsDataByPinResponse zagsDataByPinResponse;
        
        public zagsDataByPinResponse1() { }
        
        public zagsDataByPinResponse1(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsDataByPinResponse zagsDataByPinResponse)
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
        public GrsZags.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsZags.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsZags.zagsPinsByNSPDate zagsPinsByNSPDate;
        
        public zagsPinsByNSPDateRequest1() { }
        
        public zagsPinsByNSPDateRequest1(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsPinsByNSPDate zagsPinsByNSPDate)
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
        public GrsZags.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public GrsZags.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string issue;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk-seccurity-infocom.x-road.fi/producer", Order=0)]
        public GrsZags.zagsPinsByNSPDateResponse zagsPinsByNSPDateResponse;
        
        public zagsPinsByNSPDateResponse1() { }
        
        public zagsPinsByNSPDateResponse1(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsPinsByNSPDateResponse zagsPinsByNSPDateResponse)
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

    public interface InfocomServicePortTypeChannel : GrsZags.InfocomServicePortType, System.ServiceModel.IClientChannel { }
    
    public partial class InfocomServicePortTypeClient : System.ServiceModel.ClientBase<GrsZags.InfocomServicePortType>, GrsZags.InfocomServicePortType
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
        System.Threading.Tasks.Task<GrsZags.zagsDataByPinResponse1> GrsZags.InfocomServicePortType.zagsDataByPinAsync(GrsZags.zagsDataByPinRequest1 request)
        {
            return base.Channel.zagsDataByPinAsync(request);
        }

        public System.Threading.Tasks.Task<GrsZags.zagsDataByPinResponse1> zagsDataByPinAsync(GrsZags.zagsDataByPinRequest1 inValue)
        {
            return ((GrsZags.InfocomServicePortType)(this)).zagsDataByPinAsync(inValue);
        }

        public System.Threading.Tasks.Task<GrsZags.zagsDataByPinResponse1> zagsDataByPinAsync(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsDataByPin zagsDataByPin)
        {
            GrsZags.zagsDataByPinRequest1 inValue = new GrsZags.zagsDataByPinRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.zagsDataByPin = zagsDataByPin;
            return ((GrsZags.InfocomServicePortType)(this)).zagsDataByPinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GrsZags.zagsPinsByNSPDateResponse1> GrsZags.InfocomServicePortType.zagsPinsByNSPDateAsync(GrsZags.zagsPinsByNSPDateRequest1 request)
        {
            return base.Channel.zagsPinsByNSPDateAsync(request);
        }

        public System.Threading.Tasks.Task<GrsZags.zagsPinsByNSPDateResponse1> zagsPinsByNSPDateAsync(GrsZags.zagsPinsByNSPDateRequest1 inValue)
        {
            return ((GrsZags.InfocomServicePortType)(this)).zagsPinsByNSPDateAsync(inValue);
        }

        public System.Threading.Tasks.Task<GrsZags.zagsPinsByNSPDateResponse1> zagsPinsByNSPDateAsync(GrsZags.XRoadClientIdentifierType client, GrsZags.XRoadServiceIdentifierType service, string userId, string id, string issue, string protocolVersion, GrsZags.zagsPinsByNSPDate zagsPinsByNSPDate)
        {
            GrsZags.zagsPinsByNSPDateRequest1 inValue = new GrsZags.zagsPinsByNSPDateRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.issue = issue;
            inValue.protocolVersion = protocolVersion;
            inValue.zagsPinsByNSPDate = zagsPinsByNSPDate;
            return ((GrsZags.InfocomServicePortType)(this)).zagsPinsByNSPDateAsync(inValue);
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
