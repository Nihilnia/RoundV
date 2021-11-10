using Microsoft.EntityFrameworkCore.Migrations;

namespace _4_oneToOne.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    YearOfBirth = table.Column<int>(type: "INTEGER", nullable: false),
                    isBand = table.Column<bool>(type: "INTEGER", nullable: false),
                    Varios = table.Column<string>(type: "TEXT", nullable: true),
                    ArtistID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Infos_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Infos_ArtistID",
                table: "Infos",
                column: "ArtistID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
