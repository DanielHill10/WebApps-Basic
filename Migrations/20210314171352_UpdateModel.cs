using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApps.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequiredBy",
                table: "TaskItems",
                newName: "DueDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "TaskItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "TaskItems");

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "TaskItems",
                newName: "RequiredBy");
        }
    }
}
