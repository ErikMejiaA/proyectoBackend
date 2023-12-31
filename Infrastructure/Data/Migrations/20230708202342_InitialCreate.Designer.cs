﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(ProyectoBackendContext))]
    [Migration("20230708202342_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Bodega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Id_responsable")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Update_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Created_by");

                    b.HasIndex("Id_responsable");

                    b.HasIndex("Update_by");

                    b.ToTable("Bodegas", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Id_bodega_destino")
                        .HasColumnType("int");

                    b.Property<int>("Id_bodega_origen")
                        .HasColumnType("int");

                    b.Property<int>("Id_inventario")
                        .HasColumnType("int");

                    b.Property<int>("Update_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Created_by");

                    b.HasIndex("Id_bodega_destino");

                    b.HasIndex("Id_bodega_origen");

                    b.HasIndex("Id_inventario");

                    b.HasIndex("Update_by");

                    b.ToTable("Historiales", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Id_bodega")
                        .HasColumnType("int");

                    b.Property<int>("Id_producto")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Updated_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Created_by");

                    b.HasIndex("Id_bodega")
                        .IsUnique();

                    b.HasIndex("Id_producto")
                        .IsUnique();

                    b.HasIndex("Updated_by");

                    b.ToTable("Inventarios", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Estado")
                        .HasColumnType("int(4)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Update_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Created_by");

                    b.HasIndex("Update_by");

                    b.ToTable("Productos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Email_verified_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Estado")
                        .HasColumnType("int(4)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Update_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Bodega", b =>
                {
                    b.HasOne("Core.Entities.User", "UserDos")
                        .WithMany("BodegasDos")
                        .HasForeignKey("Created_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserUno")
                        .WithMany("BodegasUno")
                        .HasForeignKey("Id_responsable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserTres")
                        .WithMany("BodegasTres")
                        .HasForeignKey("Update_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDos");

                    b.Navigation("UserTres");

                    b.Navigation("UserUno");
                });

            modelBuilder.Entity("Core.Entities.Historial", b =>
                {
                    b.HasOne("Core.Entities.User", "UserUno")
                        .WithMany("HistorialesUno")
                        .HasForeignKey("Created_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Bodega", "BodegaDos")
                        .WithMany("HistorialesDos")
                        .HasForeignKey("Id_bodega_destino")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Bodega", "BodegaUno")
                        .WithMany("HistorialesUno")
                        .HasForeignKey("Id_bodega_origen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Inventario", "Inventario")
                        .WithMany("Historiales")
                        .HasForeignKey("Id_inventario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserDos")
                        .WithMany("HistorialesDos")
                        .HasForeignKey("Update_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodegaDos");

                    b.Navigation("BodegaUno");

                    b.Navigation("Inventario");

                    b.Navigation("UserDos");

                    b.Navigation("UserUno");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.HasOne("Core.Entities.User", "UserUno")
                        .WithMany("InventariosUno")
                        .HasForeignKey("Created_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Bodega", "Bodega")
                        .WithMany("Inventarios")
                        .HasForeignKey("Id_bodega")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Producto", "Producto")
                        .WithMany("Inventarios")
                        .HasForeignKey("Id_producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserDos")
                        .WithMany("InventariosDos")
                        .HasForeignKey("Updated_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bodega");

                    b.Navigation("Producto");

                    b.Navigation("UserDos");

                    b.Navigation("UserUno");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.HasOne("Core.Entities.User", "UserUno")
                        .WithMany("ProductosUno")
                        .HasForeignKey("Created_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserDos")
                        .WithMany("ProductosDos")
                        .HasForeignKey("Update_by")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDos");

                    b.Navigation("UserUno");
                });

            modelBuilder.Entity("Core.Entities.Bodega", b =>
                {
                    b.Navigation("HistorialesDos");

                    b.Navigation("HistorialesUno");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Navigation("Historiales");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Navigation("BodegasDos");

                    b.Navigation("BodegasTres");

                    b.Navigation("BodegasUno");

                    b.Navigation("HistorialesDos");

                    b.Navigation("HistorialesUno");

                    b.Navigation("InventariosDos");

                    b.Navigation("InventariosUno");

                    b.Navigation("ProductosDos");

                    b.Navigation("ProductosUno");
                });
#pragma warning restore 612, 618
        }
    }
}
