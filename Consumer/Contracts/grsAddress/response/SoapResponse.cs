namespace Gkdr.Consumer.Contracts.grsAddress.response
{
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://x-road.eu/xsd/xroad.xsd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://x-road.eu/xsd/xroad.xsd", IsNullable = false)]
    public class client
    {
        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string xRoadInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string memberClass { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public uint memberCode { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string subsystemCode { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://x-road.eu/xsd/identifiers")]
        public string objectType { get; set; }
    }

    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://x-road.eu/xsd/xroad.xsd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://x-road.eu/xsd/xroad.xsd", IsNullable = false)]
    public class service
    {
        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string xRoadInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string memberClass { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public uint memberCode { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string subsystemCode { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string serviceCode { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/identifiers")]
        public string serviceVersion { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://x-road.eu/xsd/identifiers")]
        public string objectType { get; set; }
    }
    
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeHeader
    {
        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public client client { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public service service { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public byte userId { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public byte id { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public byte issue { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public decimal protocolVersion { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public requestHash requestHash { get; set; }
    }
    
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://x-road.eu/xsd/xroad.xsd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://x-road.eu/xsd/xroad.xsd", IsNullable = false)]
    public class requestHash
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string algorithmId { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Value { get; set; }
    }
    
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeBody { }
    
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public class Envelope
    {
        public EnvelopeHeader Header { get; set; }
        public EnvelopeBody Body { get; set; }
    }
}