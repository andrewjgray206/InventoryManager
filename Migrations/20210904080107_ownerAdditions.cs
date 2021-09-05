using Microsoft.EntityFrameworkCore.Migrations;

namespace InvenManager.Migrations
{
    public partial class ownerAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "AssetModel");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "AssetModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetModel_OwnerID",
                table: "AssetModel",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetModel_Owner_OwnerID",
                table: "AssetModel",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetModel_Owner_OwnerID",
                table: "AssetModel");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_AssetModel_OwnerID",
                table: "AssetModel");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "AssetModel");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "AssetModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
