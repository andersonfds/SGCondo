using SGCondo.Domain.Base;
using System;

namespace SGCondo.Domain
{
    public class Resident : BaseDomain
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}
