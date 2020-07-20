using System;

namespace Gkdr.Producer.models
{
    public class Adjudications
    {
        public int Id { get; set; }
        public int IdOrganzation { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public virtual Organizations IdOrganzationNavigation { get; set; }
    }
}
