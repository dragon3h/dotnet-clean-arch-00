using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class MascotConfigurations : IEntityTypeConfiguration<Mascot>
    {
        public void Configure(EntityTypeBuilder<Mascot> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Code).HasMaxLength(20);
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.HasOne(d => d.Make)
                .WithMany(p => p.Mascots)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mascots_Make");
        }
    }
}
