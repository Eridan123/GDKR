using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Distinct
    {
        public Distinct()
        {
            Cities = new HashSet<Cities>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdRegion { get; set; }

        public virtual Regions IdRegionNavigation { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}
