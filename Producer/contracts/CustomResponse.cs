using System;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace Gkdr.Producer.contracts
{
    [XmlType(TypeName = "Organization", Namespace = "http://producer.xroad.com")]
    public class CustomResponse : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        
        [XRoadXmlElement(ElementName = "Licence", IsOptional = false, Order = 1)]
        public string Licence { get; set; }
        
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 2)]
        public DateTime RegistrationDate { get; set; }
        
        [XRoadXmlElement(ElementName = "Phone", IsOptional = false, Order = 3)]
        public string Phone { get; set; }
        
        [XRoadXmlElement(ElementName = "WebSite", IsOptional = false, Order = 4)]
        public string WebSite { get; set; }
        
        [XRoadXmlElement(ElementName = "Email", IsOptional = false, Order = 5)]
        public string Email { get; set; }
        
        [XRoadXmlElement(ElementName = "Forbidden", IsOptional = false, Order = 6)]
        public bool Forbidden { get; set; }
        
        [XRoadXmlElement(ElementName = "District", IsOptional = false, Order = 7)]
        public string District { get; set; }
        
        [XRoadXmlElement(ElementName = "Region", IsOptional = false, Order = 8)]
        public string Region { get; set; }
        
        [XRoadXmlElement(ElementName = "City", IsOptional = false, Order = 9)]
        public string City { get; set; }
        
        [XRoadXmlElement(ElementName = "Address", IsOptional = false, Order = 10)]
        public string Address { get; set; }
        
        [XRoadXmlElement(ElementName = "Religion", IsOptional = false, Order = 11)]
        public string Religion { get; set; }
        
        [XRoadXmlElement(ElementName = "SubReligion", IsOptional = false, Order = 12)]
        public string SubReligion { get; set; }
    }
}