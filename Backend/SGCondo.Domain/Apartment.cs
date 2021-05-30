using SGCondo.Domain.Base;
using System.Collections.Generic;

namespace SGCondo.Domain
{
    public class Apartment : BaseDomain
    {
        public int Number { get; set; }

        public int Block { get; set; }

        public IEnumerable<Resident> Residents { get; set; }
    }
}
