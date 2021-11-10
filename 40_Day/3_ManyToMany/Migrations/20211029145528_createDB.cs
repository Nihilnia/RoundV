using Microsoft.EntityFrameworkCore.Migrations;

namespace _3_ManyToMany.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MuhendislerProjeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuhendislerProjeler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Muhendisler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bolum = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Ad = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Brans = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ProjeID = table.Column<int>(type: "INTEGER", nullable: false),
                    MuhendisProjeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendisler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Muhendisler_MuhendislerProjeler_MuhendisProjeID",
                        column: x => x.MuhendisProjeID,
                        principalTable: "MuhendislerProjeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Tanim = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Baslangic = table.Column<double>(type: "REAL", nullable: false),
                    Bitis = table.Column<double>(type: "REAL", nullable: false),
                    MuhendisID = table.Column<int>(type: "INTEGER", nullable: false),
                    MuhendisProjeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Projeler_MuhendislerProjeler_MuhendisProjeID",
                        column: x => x.MuhendisProjeID,
                        principalTable: "MuhendislerProjeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MuhendisProje",
                columns: table => new
                {
                    MuhendislerID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjelerID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuhendisProje", x => new { x.MuhendislerID, x.ProjelerID });
                    table.ForeignKey(
                        name: "FK_MuhendisProje_Muhendisler_MuhendislerID",
                        column: x => x.MuhendislerID,
                        principalTable: "Muhendisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuhendisProje_Projeler_ProjelerID",
                        column: x => x.ProjelerID,
                        principalTable: "Projeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Muhendisler_MuhendisProjeID",
                table: "Muhendisler",
                column: "MuhendisProjeID");

            migrationBuilder.CreateIndex(
                name: "IX_MuhendisProje_ProjelerID",
                table: "MuhendisProje",
                column: "ProjelerID");

            migrationBuilder.CreateIndex(
                name: "IX_Projeler_MuhendisProjeID",
                table: "Projeler",
                column: "MuhendisProjeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MuhendisProje");

            migrationBuilder.DropTable(
                name: "Muhendisler");

            migrationBuilder.DropTable(
                name: "Projeler");

            migrationBuilder.DropTable(
                name: "MuhendislerProjeler");
        }
    }
}
