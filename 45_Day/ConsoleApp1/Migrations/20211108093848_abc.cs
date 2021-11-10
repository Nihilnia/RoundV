using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tries", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tries");
        }
    }
}
