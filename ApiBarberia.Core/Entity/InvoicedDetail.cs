﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class InvoicedDetail
    {
        public int Id { get; set; }
        public int IdService { get; set; }
        public int IdInvoice { get; set; }
        public bool? State { get; set; }
        public virtual Invoice IdInvoiceNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
    }
}
