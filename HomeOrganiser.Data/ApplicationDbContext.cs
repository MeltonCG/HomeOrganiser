using HomeOrganiser.Core.Entities;
using HomeOrganiser.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HomeOrganiser.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Utility> Utilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UtilityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}