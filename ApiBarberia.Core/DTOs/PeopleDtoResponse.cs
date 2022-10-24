using ApiBarberia.Core.Entity;
using System;

namespace ApiBarberia.Core.DTOs
{
    public class PeopleDtoResponse : BaseEntity
    {
        public int IdTypeDocument { get; set; }
        public int IdGender { get; set; }
        public int IdTypeRole { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public string Telephone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
