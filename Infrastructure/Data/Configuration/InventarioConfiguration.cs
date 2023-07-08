using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventarios");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasIndex(p => p.Id_bodega)
        .IsUnique();

        builder.HasIndex(p => p.Id_producto)
        .IsUnique();

        builder.Property(p => p.Cantidad)
        .IsRequired()
        .HasColumnType("int(11)");

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

        builder.HasOne(p => p.Bodega)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.Id_bodega)
        .IsRequired();

        builder.HasOne(p => p.Producto)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.Id_producto)
        .IsRequired();

        builder.HasOne(p => p.UserUno)
        .WithMany(p => p.InventariosUno)
        .HasForeignKey(p => p.Created_by)
        .IsRequired();

        builder.HasOne(p => p.UserDos)
        .WithMany(p => p.InventariosDos)
        .HasForeignKey(p => p.Updated_by)
        .IsRequired();
        
    }
}
