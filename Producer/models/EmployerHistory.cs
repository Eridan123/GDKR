using System;


namespace Gkdr.Producer.models
{
    public class EmployerHistory
    {
        public int Id { get; set; }
        public int IdEmployer { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int IdOrganization { get; set; }
        public int? IdSpeciality { get; set; }
        public short? Status { get; set; }

        public virtual Employers IdEmployerNavigation { get; set; }
        public virtual Organizations IdOrganizationNavigation { get; set; }
        public virtual Speciality IdSpecialityNavigation { get; set; }
    }
}
