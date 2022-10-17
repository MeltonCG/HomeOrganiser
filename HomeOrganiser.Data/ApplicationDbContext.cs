using HomeOrganiser.Core.Entities;
using HomeOrganiser.Data.Configuration;
using System.Data.Entity;

namespace HomeOrganiser.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Utility> Utilities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UtilityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}