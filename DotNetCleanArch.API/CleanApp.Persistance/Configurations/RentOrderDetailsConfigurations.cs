using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class RentOrderDetailsConfigurations : IEntityTypeConfiguration<RentOrderDetails>
    {
        public void Configure(EntityTypeBuilder<RentOrderDetails> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Deposit).HasColumnType("money");
            builder.Property(e => e.Quantity).HasDefaultValueSql("((1))");
            builder.Property(e => e.UnitPrice).HasColumnType("money");
            builder.Property(e => e.Discount).HasColumnType("money");
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.HasOne(d => d.Mascot)
                .WithMany(p => p.RentOrderDetails)
                .HasForeignKey(d => d.MascotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentOrderDetails_Mascot");
            builder.HasOne(d => d.RentOrder)
                .WithMany(p => p.RentOrderDetails)
                .HasForeignKey(d => d.RentOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentOrderDetails_RentOrder");
        }
    }
}
