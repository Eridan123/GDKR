using System;


namespace Gkdr.Producer.models
{
    public class Violations
    {
        public int Id { get; set; }
        public int IdOrganization { get; set; }
        public DateTime Date { get; set; }
        public string PersonNameViolation { get; set; }
        public int IdType { get; set; }

        public virtual Violationtypes IdTypeNavigation { get; set; }
    }
}
