using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bayi.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnaBayiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaBayiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltBayiAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<long>(type: "bigint", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaBayiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AltBayiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltBayiAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnaBayiId = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<long>(type: "bigint", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltBayiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltBayiler_AnaBayiler_AnaBayiId",
                        column: x => x.AnaBayiId,
                        principalTable: "AnaBayiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnaBayiler",
                columns: new[] { "Id", "AltBayiAdi", "AnaBayiAdi", "Il", "Ilce", "Mail", "Telefon" },
                values: new object[] { 1, "AltTest", "Test Bayi", "İstanbul", "Kartal", "xxx@xxx.xx", 2160000L });

            migrationBuilder.InsertData(
                table: "AltBayiler",
                columns: new[] { "Id", "AltBayiAdi", "AnaBayiId", "Il", "Ilce", "Mail", "Telefon" },
                values: new object[] { 1, "AltTest", 1, "İstanbul", "Maltepe", "xxx@xx.x", 21424L });

            migrationBuilder.CreateIndex(
                name: "IX_AltBayiler_AnaBayiId",
                table: "AltBayiler",
                column: "AnaBayiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltBayiler");

            migrationBuilder.DropTable(
                name: "AnaBayiler");
        }
    }
}
