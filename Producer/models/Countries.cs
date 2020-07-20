using System.Collections.Generic;

namespace Gkdr.Producer.models
{
    public class Countries
    {
        public Countries()
        {
            Employers = new HashSet<Employers>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employers> Employers { get; set; }
    }
}
