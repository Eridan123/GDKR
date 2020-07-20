using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Regions
    {
        public Regions()
        {
            Distinct = new HashSet<Distinct>();
            UserRegions = new HashSet<UserRegions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short IdCountry { get; set; }

        public virtual ICollection<Distinct> Distinct { get; set; }
        public virtual ICollection<UserRegions> UserRegions { get; set; }
    }
}
