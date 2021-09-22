using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNet_Final.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "TheacherImages");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Theachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "TheacherImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Theachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "TheacherImages");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "TheacherImages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
