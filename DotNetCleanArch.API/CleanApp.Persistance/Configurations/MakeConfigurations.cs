using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class MakeConfigurations : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Code).HasMaxLength(20);
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.Property(e => e.Email).HasMaxLength(200);
            builder.Property(e => e.Phone).HasMaxLength(20);
            builder.HasOne(d => d.Address)
                .WithMany(p => p.Makes)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Makes_Addresses");
        }
    }
}
