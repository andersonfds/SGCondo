using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCondo.Data.DataContext;
using SGCondo.Domain;

namespace SGCondo.Data.Mapping
{
    class ResidentMap : EntityTypeConfiguration<Resident>
    {
        public override void Configure(EntityTypeBuilder<Resident> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
