using HomeOrganiser.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HomeOrganiser.Data.Configuration
{
    public class UtilityConfig : EntityTypeConfiguration<Utility>
    {
        public UtilityConfig()
        {
            this.ToTable("Utilities");

            this.Property(e => e.UtilityType)
                .IsRequired();

            this.Property(e => e.Provider)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(e => e.CurrentPrice)
                .IsRequired();

            this.Property(e => e.ContractLength)
                .IsRequired();

            this.Property(e => e.ContractEndDate)
                .IsRequired();
        }
    }
}
