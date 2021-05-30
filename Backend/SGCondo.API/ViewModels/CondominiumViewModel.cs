using System;
using System.Collections.Generic;

namespace SGCondo.API.ViewModels
{
    public class CondominiumViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<ApartmentViewModel> Apartments { get; set; }
    }
}
