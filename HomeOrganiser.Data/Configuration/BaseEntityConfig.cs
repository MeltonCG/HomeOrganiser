using HomeOrganiser.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HomeOrganiser.Data.Configuration
{
    public abstract class BaseEntityConfig<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityConfig()
        {
            this.Property(e => e.Id)
                .HasColumnName("ID");

            this.Property(e => e.CreatedOn).HasColumnType("datetime");

            this.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}
