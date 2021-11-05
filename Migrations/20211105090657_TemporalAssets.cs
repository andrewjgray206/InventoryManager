using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenManager.Migrations
{
    public partial class TemporalAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetModel_Owner_OwnerID",
                table: "AssetModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetModel",
                table: "AssetModel");

            migrationBuilder.RenameTable(
                name: "AssetModel",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_AssetModel_OwnerID",
                table: "Assets",
                newName: "IX_Assets_OwnerID");

            migrationBuilder.AlterTable(
                name: "Assets")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodEnd",
                table: "Assets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodStart",
                table: "Assets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Owner_OwnerID",
                table: "Assets",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Owner_OwnerID",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropColumn(
                name: "PeriodEnd",
                table: "Assets")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropColumn(
                name: "PeriodStart",
                table: "Assets")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "AssetModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameIndex(
                name: "IX_Assets_OwnerID",
                table: "AssetModel",
                newName: "IX_AssetModel_OwnerID");

            migrationBuilder.AlterTable(
                name: "AssetModel")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "AssetModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetModel",
                table: "AssetModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetModel_Owner_OwnerID",
                table: "AssetModel",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "ID");
        }
    }
}
