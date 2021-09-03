using Microsoft.EntityFrameworkCore.Migrations;

namespace InvenManager.Migrations
{
    public partial class InvenDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AssetModel",
                newName: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item",
                table: "AssetModel",
                newName: "Name");
        }
    }
}
