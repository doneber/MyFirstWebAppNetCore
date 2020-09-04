using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstWebAppNetCore.Migrations
{
    public partial class MySecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Tasks",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Tasks",
                newName: "Content");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Tasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Tasks",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Tasks",
                newName: "content");
        }
    }
}
