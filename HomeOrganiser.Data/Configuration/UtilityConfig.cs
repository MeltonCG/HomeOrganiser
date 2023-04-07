using HomeOrganiser.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeOrganiser.Data.Configuration
{
    public class UtilityConfig : BaseEntityConfig<Utility>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Utility> builder)
        {
            builder.ToTable("Utilities");

            builder.Property(e => e.UtilityType)
                .IsRequired();

            builder.Property(e => e.Provider)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
