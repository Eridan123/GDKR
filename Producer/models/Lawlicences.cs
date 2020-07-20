using System;


namespace Gkdr.Producer.models
{
    public class Lawlicences
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateIssue { get; set; }
        public int IdOrganization { get; set; }
        public short Status { get; set; }

        public virtual Organizations IdOrganizationNavigation { get; set; }
    }
}
