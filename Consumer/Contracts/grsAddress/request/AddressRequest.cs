namespace Gkdr.Consumer.Contracts.grsAddress.request
{
    public class AsbAddress : EnvelopeBody
    {
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public asbAddress asbAddress { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer", IsNullable = false)]
    public class asbAddress
    {
        public asbAddressRequest request { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressRequest
    {
        public ulong pin { get; set; }
    }
}