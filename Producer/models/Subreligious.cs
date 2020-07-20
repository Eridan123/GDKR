﻿using System;
using System.Collections.Generic;


namespace Gkdr.Producer.models
{
    public class Subreligious
    {
        public Subreligious()
        {
            Organizations = new HashSet<Organizations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdReligion { get; set; }

        public virtual Religious IdReligionNavigation { get; set; }
        public virtual ICollection<Organizations> Organizations { get; set; }
    }
}
