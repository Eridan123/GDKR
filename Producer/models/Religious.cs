using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Religious
    {
        public Religious()
        {
            Subreligious = new HashSet<Subreligious>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Subreligious> Subreligious { get; set; }
    }
}
