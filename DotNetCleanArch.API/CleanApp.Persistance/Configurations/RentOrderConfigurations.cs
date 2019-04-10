using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class RentOrderConfigurations : IEntityTypeConfiguration<RentOrder>
    {
        public void Configure(EntityTypeBuilder<RentOrder> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ShippingPrice).HasColumnType("money");
            builder.Property(e => e.PaymentDate).HasColumnType("datetime");
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.Property(e => e.FromDate).HasColumnType("datetime");
            builder.Property(e => e.ToDate).HasColumnType("datetime");
            builder.HasOne(d => d.Client)
                .WithMany(p => p.RentOrders)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentOrders_Clients");
        }
    }
}
