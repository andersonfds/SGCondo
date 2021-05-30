using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCondo.Data.DataContext;
using SGCondo.Domain;

namespace SGCondo.Data.Mapping
{
    public class ApartmentMap : EntityTypeConfiguration<Apartment>
    {
        public override void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
