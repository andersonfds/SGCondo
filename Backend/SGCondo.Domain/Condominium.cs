using SGCondo.Domain.Base;
using System.Collections.Generic;

namespace SGCondo.Domain
{
    public class Condominium : BaseDomain
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual IEnumerable<Apartment> Apartments { get; set; }
    }
}
