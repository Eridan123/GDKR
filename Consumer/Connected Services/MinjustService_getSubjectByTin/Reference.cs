﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinjustService_getSubjectByTin
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tunduk.gov.kg", ConfigurationName="MinjustService_getSubjectByTin.SubjectPort")]
    public interface SubjectPort
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(XRoadIdentifierType))]
        System.Threading.Tasks.Task<MinjustService_getSubjectByTin.getSubjectByTinResponse1> getSubjectByTinAsync(MinjustService_getSubjectByTin.getSubjectByTinRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadClientIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadLocalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadGlobalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityServerIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadCentralServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityCategoryIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadClientIdentifierType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadIdentifierType
    {
        
        private string xRoadInstanceField;
        
        private string memberClassField;
        
        private string memberCodeField;
        
        private string subsystemCodeField;
        
        private string groupCodeField;
        
        private string serviceCodeField;
        
        private string serviceVersionField;
        
        private string securityCategoryCodeField;
        
        private string serverCodeField;
        
        private XRoadObjectType objectTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string xRoadInstance
        {
            get
            {
                return this.xRoadInstanceField;
            }
            set
            {
                this.xRoadInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string memberClass
        {
            get
            {
                return this.memberClassField;
            }
            set
            {
                this.memberClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string memberCode
        {
            get
            {
                return this.memberCodeField;
            }
            set
            {
                this.memberCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string subsystemCode
        {
            get
            {
                return this.subsystemCodeField;
            }
            set
            {
                this.subsystemCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string groupCode
        {
            get
            {
                return this.groupCodeField;
            }
            set
            {
                this.groupCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string serviceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string serviceVersion
        {
            get
            {
                return this.serviceVersionField;
            }
            set
            {
                this.serviceVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string securityCategoryCode
        {
            get
            {
                return this.securityCategoryCodeField;
            }
            set
            {
                this.securityCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string serverCode
        {
            get
            {
                return this.serverCodeField;
            }
            set
            {
                this.serverCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public XRoadObjectType objectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public enum XRoadObjectType
    {
        
        /// <remarks/>
        MEMBER,
        
        /// <remarks/>
        SUBSYSTEM,
        
        /// <remarks/>
        SERVER,
        
        /// <remarks/>
        GLOBALGROUP,
        
        /// <remarks/>
        LOCALGROUP,
        
        /// <remarks/>
        SECURITYCATEGORY,
        
        /// <remarks/>
        SERVICE,
        
        /// <remarks/>
        CENTRALSERVICE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tunduk.gov.kg")]
    public partial class getSubjectByTinResponse
    {
        
        private string fullNameGlField;
        
        private string shortNameGlField;
        
        private string fullNameOlField;
        
        private string shortNameOlField;
        
        private bool foreignPartField;
        
        private string registrCodeField;
        
        private string statSubCodeField;
        
        private string tinField;
        
        private string regionField;
        
        private string districtField;
        
        private string cityField;
        
        private string villageField;
        
        private string microdistrictField;
        
        private string streetField;
        
        private string houseField;
        
        private string roomField;
        
        private string phonesField;
        
        private string email1Field;
        
        private string email2Field;
        
        private string orderDateField;
        
        private string firstOrderDateField;
        
        private long ownershipField;
        
        private string chiefTinField;
        
        private string baseBusField;
        
        private string baseBusCodeField;
        
        private int indFoundersField;
        
        private int jurFoundersField;
        
        private int totalFoundersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string fullNameGl
        {
            get
            {
                return this.fullNameGlField;
            }
            set
            {
                this.fullNameGlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string shortNameGl
        {
            get
            {
                return this.shortNameGlField;
            }
            set
            {
                this.shortNameGlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string fullNameOl
        {
            get
            {
                return this.fullNameOlField;
            }
            set
            {
                this.fullNameOlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string shortNameOl
        {
            get
            {
                return this.shortNameOlField;
            }
            set
            {
                this.shortNameOlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool foreignPart
        {
            get
            {
                return this.foreignPartField;
            }
            set
            {
                this.foreignPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string registrCode
        {
            get
            {
                return this.registrCodeField;
            }
            set
            {
                this.registrCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string statSubCode
        {
            get
            {
                return this.statSubCodeField;
            }
            set
            {
                this.statSubCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string tin
        {
            get
            {
                return this.tinField;
            }
            set
            {
                this.tinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string village
        {
            get
            {
                return this.villageField;
            }
            set
            {
                this.villageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string microdistrict
        {
            get
            {
                return this.microdistrictField;
            }
            set
            {
                this.microdistrictField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string house
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string phones
        {
            get
            {
                return this.phonesField;
            }
            set
            {
                this.phonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string email1
        {
            get
            {
                return this.email1Field;
            }
            set
            {
                this.email1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string email2
        {
            get
            {
                return this.email2Field;
            }
            set
            {
                this.email2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string firstOrderDate
        {
            get
            {
                return this.firstOrderDateField;
            }
            set
            {
                this.firstOrderDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public long ownership
        {
            get
            {
                return this.ownershipField;
            }
            set
            {
                this.ownershipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string chiefTin
        {
            get
            {
                return this.chiefTinField;
            }
            set
            {
                this.chiefTinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string baseBus
        {
            get
            {
                return this.baseBusField;
            }
            set
            {
                this.baseBusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string baseBusCode
        {
            get
            {
                return this.baseBusCodeField;
            }
            set
            {
                this.baseBusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public int indFounders
        {
            get
            {
                return this.indFoundersField;
            }
            set
            {
                this.indFoundersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public int jurFounders
        {
            get
            {
                return this.jurFoundersField;
            }
            set
            {
                this.jurFoundersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public int totalFounders
        {
            get
            {
                return this.totalFoundersField;
            }
            set
            {
                this.totalFoundersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tunduk.gov.kg")]
    public partial class getSubjectByTinRequest
    {
        
        private string tinField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string tin
        {
            get
            {
                return this.tinField;
            }
            set
            {
                this.tinField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadLocalGroupIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadGlobalGroupIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadSecurityServerIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadCentralServiceIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadSecurityCategoryIdentifierType : XRoadIdentifierType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public partial class XRoadServiceIdentifierType : XRoadIdentifierType
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getSubjectByTinRequest1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public MinjustService_getSubjectByTin.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public MinjustService_getSubjectByTin.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk.gov.kg", Order=0)]
        public MinjustService_getSubjectByTin.getSubjectByTinRequest getSubjectByTinRequest;
        
        public getSubjectByTinRequest1()
        {
        }
        
        public getSubjectByTinRequest1(MinjustService_getSubjectByTin.XRoadClientIdentifierType client, MinjustService_getSubjectByTin.XRoadServiceIdentifierType service, string userId, string id, string protocolVersion, MinjustService_getSubjectByTin.getSubjectByTinRequest getSubjectByTinRequest)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.protocolVersion = protocolVersion;
            this.getSubjectByTinRequest = getSubjectByTinRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getSubjectByTinResponse1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public MinjustService_getSubjectByTin.XRoadClientIdentifierType client;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public MinjustService_getSubjectByTin.XRoadServiceIdentifierType service;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string userId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://x-road.eu/xsd/xroad.xsd")]
        public string protocolVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tunduk.gov.kg", Order=0)]
        public MinjustService_getSubjectByTin.getSubjectByTinResponse getSubjectByTinResponse;
        
        public getSubjectByTinResponse1()
        {
        }
        
        public getSubjectByTinResponse1(MinjustService_getSubjectByTin.XRoadClientIdentifierType client, MinjustService_getSubjectByTin.XRoadServiceIdentifierType service, string userId, string id, string protocolVersion, MinjustService_getSubjectByTin.getSubjectByTinResponse getSubjectByTinResponse)
        {
            this.client = client;
            this.service = service;
            this.userId = userId;
            this.id = id;
            this.protocolVersion = protocolVersion;
            this.getSubjectByTinResponse = getSubjectByTinResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface SubjectPortChannel : MinjustService_getSubjectByTin.SubjectPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class SubjectPortClient : System.ServiceModel.ClientBase<MinjustService_getSubjectByTin.SubjectPort>, MinjustService_getSubjectByTin.SubjectPort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SubjectPortClient() : 
                base(SubjectPortClient.GetDefaultBinding(), SubjectPortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SubjectPortSoap11.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubjectPortClient(EndpointConfiguration endpointConfiguration) : 
                base(SubjectPortClient.GetBindingForEndpoint(endpointConfiguration), SubjectPortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubjectPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SubjectPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubjectPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SubjectPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubjectPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MinjustService_getSubjectByTin.getSubjectByTinResponse1> MinjustService_getSubjectByTin.SubjectPort.getSubjectByTinAsync(MinjustService_getSubjectByTin.getSubjectByTinRequest1 request)
        {
            return base.Channel.getSubjectByTinAsync(request);
        }

        public System.Threading.Tasks.Task<MinjustService_getSubjectByTin.getSubjectByTinResponse1> getSubjectByTinAsync(MinjustService_getSubjectByTin.getSubjectByTinRequest1 inValue)
        {
            return ((MinjustService_getSubjectByTin.SubjectPort)(this)).getSubjectByTinAsync(inValue);
        }

        public System.Threading.Tasks.Task<MinjustService_getSubjectByTin.getSubjectByTinResponse1> getSubjectByTinAsync(MinjustService_getSubjectByTin.XRoadClientIdentifierType client, MinjustService_getSubjectByTin.XRoadServiceIdentifierType service, string userId, string id, string protocolVersion, MinjustService_getSubjectByTin.getSubjectByTinRequest getSubjectByTinRequest)
        {
            MinjustService_getSubjectByTin.getSubjectByTinRequest1 inValue = new MinjustService_getSubjectByTin.getSubjectByTinRequest1();
            inValue.client = client;
            inValue.service = service;
            inValue.userId = userId;
            inValue.id = id;
            inValue.protocolVersion = protocolVersion;
            inValue.getSubjectByTinRequest = getSubjectByTinRequest;
            return ((MinjustService_getSubjectByTin.SubjectPort)(this)).getSubjectByTinAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SubjectPortSoap11))
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
            if ((endpointConfiguration == EndpointConfiguration.SubjectPortSoap11))
            {
                return new System.ServiceModel.EndpointAddress("http://example.org/xroad-endpoint");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SubjectPortClient.GetBindingForEndpoint(EndpointConfiguration.SubjectPortSoap11);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SubjectPortClient.GetEndpointAddress(EndpointConfiguration.SubjectPortSoap11);
        }
        
        public enum EndpointConfiguration
        {
            
            SubjectPortSoap11,
        }
    }
}
