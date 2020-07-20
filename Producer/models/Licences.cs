using System;


namespace Gkdr.Producer.models
{
    public class Licences
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int IdOrganization { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime DateEnd { get; set; }
        public short Status { get; set; }
        public string OrderNumber { get; set; }

        public virtual Organizations IdOrganizationNavigation { get; set; }
    }
}
