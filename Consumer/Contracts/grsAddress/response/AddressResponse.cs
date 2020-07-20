namespace Gkdr.Consumer.Contracts.grsAddress.response
{
    public class AsbAddress : EnvelopeBody
    {
        [System.Xml.Serialization.XmlElement(Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public asbAddressResponse asbAddressResponse { get; set; }
    }

    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer", IsNullable = false)]
    public class asbAddressResponse
    {
        public asbAddressResponseRequest request { get; set; }
        public asbAddressResponseResponse response { get; set; }
    }

    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponseRequest
    {
        public ulong pin { get; set; }
    }

    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponseResponse
    {
        public bool error { get; set; }
        public string address { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public System.DateTime dateAction { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "date")]
        public System.DateTime dateCreated { get; set; }

        public asbAddressResponseResponseAddressArray addressArray { get; set; }
    }

    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
    public class asbAddressResponseResponseAddressArray
    {
        public ushort countryId { get; set; }
        public ushort regionId { get; set; }
        public ushort districtId { get; set; }
        public ushort aymakId { get; set; }
        public ushort villageId { get; set; }
        public ushort streetId { get; set; }
        public ushort houseId { get; set; }
        public byte houseTxt { get; set; }
        public byte flatId { get; set; }
        public object flatTxt { get; set; }
        public ulong code { get; set; }
        public uint post { get; set; }
    }
}
