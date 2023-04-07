using HomeOrganiser.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeOrganiser.Data.Configuration
{
    public abstract class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            ConfigureEntity(builder);
        }

        protected virtual void ConfigureEntity(EntityTypeBuilder<T> builder)
        {

        }
    }
}
