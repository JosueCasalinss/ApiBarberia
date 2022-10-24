using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBarberia.Core.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool State { get; set; }

    }
}
