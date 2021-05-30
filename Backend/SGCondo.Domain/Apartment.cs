using SGCondo.Domain.Base;
using System;
using System.Collections.Generic;

namespace SGCondo.Domain
{
    public class Apartment : BaseDomain
    {
        public int Number { get; set; }

        public int Block { get; set; }

        public Guid CondominiumId { get; set; }

        public virtual IEnumerable<Resident> Residents { get; set; }
    }
}
