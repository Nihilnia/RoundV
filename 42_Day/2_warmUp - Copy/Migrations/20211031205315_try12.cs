using Microsoft.EntityFrameworkCore.ArtistInfos;

namespace _2_warmUp.ArtistInfos
{
    public partial class try12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistIntels");

            migrationBuilder.CreateTable(
                name: "JubileeStreets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    isBand = table.Column<bool>(type: "INTEGER", nullable: false),
                    Various = table.Column<string>(type: "TEXT", nullable: true),
                    ArtistID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JubileeStreets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JubileeStreets_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JubileeStreets_ArtistID",
                table: "JubileeStreets",
                column: "ArtistID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JubileeStreets");

            migrationBuilder.CreateTable(
                name: "ArtistIntels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistID = table.Column<int>(type: "INTEGER", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    Various = table.Column<string>(type: "TEXT", nullable: true),
                    YearOfBirth = table.Column<int>(type: "INTEGER", nullable: false),
                    isBand = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistIntels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtistIntels_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistIntels_ArtistID",
                table: "ArtistIntels",
                column: "ArtistID",
                unique: true);
        }
    }
}
