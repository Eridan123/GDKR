using System;


namespace Gkdr.Producer.models
{
    public class UserRegions
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdRegion { get; set; }

        public virtual Regions IdRegionNavigation { get; set; }
        public virtual Users IdUserNavigation { get; set; }
    }
}
