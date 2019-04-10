using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.City).HasMaxLength(50);
            builder.Property(e => e.Country).HasMaxLength(100);
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.PostalCode).HasMaxLength(10);
            builder.Property(e => e.ProvinceState).HasMaxLength(200);
            builder.Property(e => e.Street).HasMaxLength(200);
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
        }
    }
}
