using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVCCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ürünler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ürünler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ürünler_Kategoriler_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Profiller",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiller", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Profiller_Kullanıcılar_ID",
                        column: x => x.ID,
                        principalTable: "Kullanıcılar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparişler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: true),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparişler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Siparişler_Kullanıcılar_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "Kullanıcılar",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SiparişDetayları",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YaratılmaTarihi = table.Column<DateTime>(name: "Yaratılma Tarihi", type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparişDetayları", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_SiparişDetayları_Siparişler_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Siparişler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparişDetayları_Ürünler_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Ürünler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiparişDetayları_ProductID",
                table: "SiparişDetayları",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparişler_AppUserID",
                table: "Siparişler",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Ürünler_CategoryID",
                table: "Ürünler",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiller");

            migrationBuilder.DropTable(
                name: "SiparişDetayları");

            migrationBuilder.DropTable(
                name: "Siparişler");

            migrationBuilder.DropTable(
                name: "Ürünler");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
