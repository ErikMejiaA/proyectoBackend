using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class HistorialConfiguration : IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        
        builder.ToTable("Historiales");

        builder.Property(p => p.Id)
        .IsRequired();

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

        builder.HasOne(p => p.BodegaUno)
        .WithMany(p => p.HistorialesUno)
        .HasForeignKey(p => p.Id_bodega_origen)
        .IsRequired();

        builder.HasOne(p => p.BodegaDos)
        .WithMany(p => p.HistorialesDos)
        .HasForeignKey(p => p.Id_bodega_destino)
        .IsRequired();

        builder.HasOne(p => p.Inventario)
        .WithMany(p => p.Historiales)
        .HasForeignKey(p => p.Id_inventario)
        .IsRequired();

        builder.HasOne(p => p.UserUno)
        .WithMany(p => p.HistorialesUno)
        .HasForeignKey(p => p.Created_by)
        .IsRequired();

        builder.HasOne(p => p.UserDos)
        .WithMany(p => p.HistorialesDos)
        .HasForeignKey(p => p.Update_by)
        .IsRequired();
        
    }
}
