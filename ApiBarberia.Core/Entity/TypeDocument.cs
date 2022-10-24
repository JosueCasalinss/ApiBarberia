﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class TypeDocument
    {
        public TypeDocument()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}