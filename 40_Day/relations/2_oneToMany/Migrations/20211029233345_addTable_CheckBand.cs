using Microsoft.EntityFrameworkCore.Migrations;

namespace _2_oneToMany.Migrations
{
    public partial class addTable_CheckBand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BandOrNot");

            migrationBuilder.CreateTable(
                name: "CheckBand",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Varios = table.Column<string>(type: "TEXT", nullable: true),
                    Check = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckBand", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckBand");

            migrationBuilder.CreateTable(
                name: "BandOrNot",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Check = table.Column<string>(type: "TEXT", nullable: true),
                    IsBand = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandOrNot", x => x.ID);
                });
        }
    }
}
