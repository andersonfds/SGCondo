using Microsoft.EntityFrameworkCore;
using SGCondo.Data.Mapping;
using SGCondo.Domain;
using SGCondo.Framework.DataContext;
using SGCondo.Framework.Security;
using System.Data.SqlClient;

namespace SGCondo.Data.DataContext
{
    public class AppDbContext : DbContext, IDbContext
    {
        #region Configuration

        private SqlConnection connection;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            connection = new SqlConnection(SystemConstants.DbConnection);
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApartmentMap());
            builder.ApplyConfiguration(new CondominiumMap());
            builder.ApplyConfiguration(new ResidentMap());
        }

        #endregion Configuration

        #region DbSets
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Condominium> Condominiums { get; set; }
        public DbSet<Resident> Residents { get; set; }
        #endregion DbSets

    }
}
