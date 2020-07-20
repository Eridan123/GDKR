using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Employers
    {
        public Employers()
        {
            EmployerHistory = new HashSet<EmployerHistory>();
            MissionerLicences = new HashSet<MissionerLicences>();
            Organizations = new HashSet<Organizations>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public string PassportNumber { get; set; }
        public int IdSpeciality { get; set; }
        public int IdCity { get; set; }
        public string PasportAddress { get; set; }
        public string Address { get; set; }
        public string Education { get; set; }
        public DateTime? DateBirth { get; set; }
        public byte[] Photo { get; set; }
        public string LicenseMessioner { get; set; }
        public DateTime? LicecnseMesionerIssueDate { get; set; }
        public string Contacts { get; set; }
        public string UniqueId { get; set; }
        public string Comments { get; set; }
        public int? IdOrganization { get; set; }
        public string OtherWorkplace { get; set; }
        public string Email { get; set; }
        public short? IdCitizenship { get; set; }
        public short IsMissioner { get; set; }
        public DateTime? DateDepart { get; set; }
        public int? IdInviteOrganization { get; set; }

        public virtual Countries IdCitizenshipNavigation { get; set; }
        public virtual Cities IdCityNavigation { get; set; }
        public virtual Organizations IdInviteOrganizationNavigation { get; set; }
        public virtual Organizations IdOrganizationNavigation { get; set; }
        public virtual Speciality IdSpecialityNavigation { get; set; }
        public virtual ICollection<EmployerHistory> EmployerHistory { get; set; }
        public virtual ICollection<MissionerLicences> MissionerLicences { get; set; }
        public virtual ICollection<Organizations> Organizations { get; set; }
    }
}
