using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Speciality
    {
        public Speciality()
        {
            EmployerHistory = new HashSet<EmployerHistory>();
            Employers = new HashSet<Employers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployerHistory> EmployerHistory { get; set; }
        public virtual ICollection<Employers> Employers { get; set; }
    }
}
