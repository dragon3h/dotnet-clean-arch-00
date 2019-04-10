using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class BuyOrderDetailsConfigurations : IEntityTypeConfiguration<BuyOrderDetails>
    {
        public void Configure(EntityTypeBuilder<BuyOrderDetails> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Quantity).HasDefaultValueSql("((1))");
            builder.Property(e => e.UnitPrice).HasColumnType("money");
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.HasOne(d => d.Mascot)
                .WithMany(p => p.BuyOrderDetails)
                .HasForeignKey(d => d.MascotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuyOrderDetails_Mascot");
            builder.HasOne(d => d.BuyOrder)
                .WithMany(p => p.BuyOrderDetails)
                .HasForeignKey(d => d.BuyOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuyOrderDetails_BuyOrder");
        }
    }
}
