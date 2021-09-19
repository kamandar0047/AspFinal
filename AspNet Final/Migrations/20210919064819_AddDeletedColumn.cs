using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNet_Final.Migrations
{
    public partial class AddDeletedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Theachers",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deleted",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Theachers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deleted",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
