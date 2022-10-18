using HomeOrganiser.Core.Entities;
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

            builder.Property(e => e.CurrentPrice)
                .IsRequired();

            builder.Property(e => e.ContractLength)
                .IsRequired();

            builder.Property(e => e.ContractEndDate)
                .IsRequired();
        }
    }
}
