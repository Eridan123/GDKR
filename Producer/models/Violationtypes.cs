using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Violationtypes
    {
        public Violationtypes()
        {
            Violations = new HashSet<Violations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Violations> Violations { get; set; }
    }
}
