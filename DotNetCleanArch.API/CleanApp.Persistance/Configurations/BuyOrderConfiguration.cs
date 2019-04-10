using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class BuyOrderConfiguration : IEntityTypeConfiguration<BuyOrder>
    {
        public void Configure(EntityTypeBuilder<BuyOrder> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Shipper).HasMaxLength(100);
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.Property(e => e.ShippingPrice).HasColumnType("money");
            builder.Property(e => e.PaymentDate).HasColumnType("datetime");
            builder.Property(e => e.ShippingDate).HasColumnType("datetime");
        }
    }
}
