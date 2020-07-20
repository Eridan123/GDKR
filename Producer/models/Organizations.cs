using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Organizations
    {
        public Organizations()
        {
            Licences = new HashSet<Licences>();
            Lawlicences = new HashSet<Lawlicences>();
            Otherlicences = new HashSet<Otherlicences>();
            Adjudications = new HashSet<Adjudications>();
            
            EmployerHistory = new HashSet<EmployerHistory>();
            EmployersIdInviteOrganizationNavigation = new HashSet<Employers>();
            EmployersIdOrganizationNavigation = new HashSet<Employers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int IdSubReligion { get; set; }
        public int IdCity { get; set; }
        public short IsBranch { get; set; }
        public int? IdMainOrganization { get; set; }
        public string Address { get; set; }
        public int? IdManager { get; set; }
        public int? IdType { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string UniqueId { get; set; }
        public short Forbidden { get; set; }
        public string Phone { get; set; }
        public int? IdDepartment { get; set; }

        public virtual Cities IdCityNavigation { get; set; }
        public virtual Employers IdManagerNavigation { get; set; }
        public virtual Subreligious IdSubReligionNavigation { get; set; }
        public virtual Organizationtypes IdTypeNavigation { get; set; }
        public virtual ICollection<Adjudications> Adjudications { get; set; }
        public virtual ICollection<EmployerHistory> EmployerHistory { get; set; }
        public virtual ICollection<Employers> EmployersIdInviteOrganizationNavigation { get; set; }
        public virtual ICollection<Employers> EmployersIdOrganizationNavigation { get; set; }
        public virtual ICollection<Lawlicences> Lawlicences { get; set; }
        public virtual ICollection<Licences> Licences { get; set; }
        public virtual ICollection<Otherlicences> Otherlicences { get; set; }
    }
}
