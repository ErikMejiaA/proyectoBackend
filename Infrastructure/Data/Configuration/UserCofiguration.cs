using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UserCofiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(255);

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Email_verified_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Estado)
        .IsRequired()
        .HasColumnType("int(4)");

        builder.Property(p => p.Created_by)
        .IsRequired();

        builder.Property(p => p.Update_by)
        .IsRequired();

        builder.Property(p => p.Foto)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Password)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Created_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Update_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Deleted_at)
        .IsRequired()
        .HasColumnType("datetime");


    }
}
