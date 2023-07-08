using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Estado)
        .IsRequired()
        .HasColumnType("int(4)");

        builder.Property(p => p.Created_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Update_at)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Deleted_at)
        .IsRequired()
        .HasColumnType("datetime");


        //Declaramos las llaves Foraneas (FOREIGN KEY)

        builder.HasOne(p => p.UserUno)
        .WithMany(p => p.ProductosUno)
        .HasForeignKey(p => p.Created_by)
        .IsRequired();

        builder.HasOne(p => p.UserDos)
        .WithMany(p => p.ProductosDos)
        .HasForeignKey(p => p.Update_by)
        .IsRequired();

    }
}
