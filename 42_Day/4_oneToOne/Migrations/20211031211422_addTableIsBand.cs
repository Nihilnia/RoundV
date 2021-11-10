using Microsoft.EntityFrameworkCore.Migrations;

namespace _4_oneToOne.Migrations
{
    public partial class addTableIsBand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsBands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TextIsBand = table.Column<string>(type: "TEXT", nullable: true),
                    InfoID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsBands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IsBands_Infos_InfoID",
                        column: x => x.InfoID,
                        principalTable: "Infos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsBands_InfoID",
                table: "IsBands",
                column: "InfoID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsBands");
        }
    }
}
