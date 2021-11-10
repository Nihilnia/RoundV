using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_manyToMany.Migrations
{
    public partial class dateTimeTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Products");
        }
    }
}
