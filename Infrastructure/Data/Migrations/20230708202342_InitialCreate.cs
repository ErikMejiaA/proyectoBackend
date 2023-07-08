using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_verified_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<int>(type: "int(4)", nullable: false),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_by = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Update_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_responsable = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_by = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_Created_by",
                        column: x => x.Created_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_Id_responsable",
                        column: x => x.Id_responsable,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_Update_by",
                        column: x => x.Update_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int(4)", nullable: false),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_by = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Update_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Users_Created_by",
                        column: x => x.Created_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Users_Update_by",
                        column: x => x.Update_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_bodega = table.Column<int>(type: "int", nullable: false),
                    Id_producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int(11)", nullable: false),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Updated_by = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventarios_Bodegas_Id_bodega",
                        column: x => x.Id_bodega,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Productos_Id_producto",
                        column: x => x.Id_producto,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Users_Created_by",
                        column: x => x.Created_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Users_Updated_by",
                        column: x => x.Updated_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int(11)", nullable: false),
                    Id_bodega_origen = table.Column<int>(type: "int", nullable: false),
                    Id_bodega_destino = table.Column<int>(type: "int", nullable: false),
                    Id_inventario = table.Column<int>(type: "int", nullable: false),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_by = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historiales_Bodegas_Id_bodega_destino",
                        column: x => x.Id_bodega_destino,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historiales_Bodegas_Id_bodega_origen",
                        column: x => x.Id_bodega_origen,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historiales_Inventarios_Id_inventario",
                        column: x => x.Id_inventario,
                        principalTable: "Inventarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historiales_Users_Created_by",
                        column: x => x.Created_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historiales_Users_Update_by",
                        column: x => x.Update_by,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_Created_by",
                table: "Bodegas",
                column: "Created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_Id_responsable",
                table: "Bodegas",
                column: "Id_responsable");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_Update_by",
                table: "Bodegas",
                column: "Update_by");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_Created_by",
                table: "Historiales",
                column: "Created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_Id_bodega_destino",
                table: "Historiales",
                column: "Id_bodega_destino");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_Id_bodega_origen",
                table: "Historiales",
                column: "Id_bodega_origen");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_Id_inventario",
                table: "Historiales",
                column: "Id_inventario");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_Update_by",
                table: "Historiales",
                column: "Update_by");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Created_by",
                table: "Inventarios",
                column: "Created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Id_bodega",
                table: "Inventarios",
                column: "Id_bodega",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Id_producto",
                table: "Inventarios",
                column: "Id_producto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Updated_by",
                table: "Inventarios",
                column: "Updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Created_by",
                table: "Productos",
                column: "Created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Update_by",
                table: "Productos",
                column: "Update_by");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historiales");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
