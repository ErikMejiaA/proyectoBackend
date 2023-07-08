using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class BodegaCofiguration : IEntityTypeConfiguration<Bodega>
{
    public void Configure(EntityTypeBuilder<Bodega> builder)
    {
        builder.ToTable("Bodegas");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Estado)
        .IsRequired();

        builder.Property(p => p.Created_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Updated_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Deleted_at)
        .IsRequired()
        .HasColumnType("datetime");

        //Declaramos las llaves Foraneas (FOREIGN KEY)

        builder.HasOne(p => p.UserUno)
        .WithMany(p => p.BodegasUno)
        .HasForeignKey(p => p.Id_responsable)
        .IsRequired();

        builder.HasOne(p => p.UserDos)
        .WithMany(p => p.BodegasDos)
        .HasForeignKey(p => p.Created_by)
        .IsRequired();

        builder.HasOne(p => p.UserTres)
        .WithMany(p => p.BodegasTres)
        .HasForeignKey(p => p.Update_by)
        .IsRequired();

    }
}
