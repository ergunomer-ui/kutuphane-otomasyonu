using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneOtomasyonu.Entities.Migrations
{
    /// <inheritdoc />
    public partial class OduncSistemiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OduncIslemleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    VerilisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OduncIslemleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OduncIslemleri_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OduncIslemleri_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OduncIslemleri_KitapId",
                table: "OduncIslemleri",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncIslemleri_UyeId",
                table: "OduncIslemleri",
                column: "UyeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OduncIslemleri");
        }
    }
}
