using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ClientID");
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            builder.Property(e => e.AddressId).HasColumnName("AddressID");
            builder.Property(e => e.Messenger).HasMaxLength(50);
            builder.Property(e => e.Phone).HasMaxLength(20);
            builder.HasOne(d => d.Address)
                .WithMany(p => p.Clients)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Clients_Address");

        }
    }
}
