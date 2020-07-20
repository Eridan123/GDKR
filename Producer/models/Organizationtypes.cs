using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Organizationtypes
    {
        public Organizationtypes()
        {
            Organizations = new HashSet<Organizations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Organizations> Organizations { get; set; }
    }
}
