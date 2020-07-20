namespace Tunduk
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadClientIdentifierType : XRoadIdentifierType { }
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadLocalGroupIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadGlobalGroupIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadSecurityServerIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadCentralServiceIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadSecurityCategoryIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadServiceIdentifierType : XRoadIdentifierType { }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadLocalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadGlobalGroupIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityServerIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadCentralServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadSecurityCategoryIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadServiceIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XRoadClientIdentifierType))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://x-road.eu/xsd/identifiers")]
    public class XRoadIdentifierType
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
}