using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCondo.Data.DataContext;
using SGCondo.Domain;

namespace SGCondo.Data.Mapping
{
    public class CondominiumMap : EntityTypeConfiguration<Condominium>
    {
        public override void Configure(EntityTypeBuilder<Condominium> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                .HasMany(e => e.Apartments)
                .WithOne();
        }
    }
}
