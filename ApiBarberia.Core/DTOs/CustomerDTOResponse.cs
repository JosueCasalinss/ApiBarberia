using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBarberia.Core.DTOs
{
    class CustomerDTOResponse
    {
        string Name { get; set;}
        int ActiveQuantity { get; set;}
        int AmountInactive { get; set;}
        string discount { get; set;}
        string Penalty { get; set;}
    }
}
