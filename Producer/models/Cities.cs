using System.Collections.Generic;

namespace Gkdr.Producer.models
{
    public class Cities
    {
        public Cities()
        {
            Employers = new HashSet<Employers>();
            Organizations = new HashSet<Organizations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdDistinct { get; set; }

        public virtual Distinct IdDistinctNavigation { get; set; }
        public virtual ICollection<Employers> Employers { get; set; }
        public virtual ICollection<Organizations> Organizations { get; set; }
    }
}
