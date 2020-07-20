using System;


namespace Gkdr.Producer.models
{
    public class Logevents
    {
        public int Id { get; set; }
        public DateTime DateLog { get; set; }
        public int IdUser { get; set; }
        public int EntityType { get; set; }
        public string Result { get; set; }
        public short Action { get; set; }
        public int IdEntry { get; set; }
    }
}
