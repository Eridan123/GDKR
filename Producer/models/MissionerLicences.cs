using System;


namespace Gkdr.Producer.models
{
    public class MissionerLicences
    {
        public int Id { get; set; }
        public int IdEmployer { get; set; }
        public DateTime DateIssue { get; set; }
        public string Number { get; set; }
        public short Status { get; set; }

        public virtual Employers IdEmployerNavigation { get; set; }
    }
}
