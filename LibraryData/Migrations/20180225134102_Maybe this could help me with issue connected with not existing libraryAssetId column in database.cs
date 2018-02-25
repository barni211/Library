using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class MaybethiscouldhelpmewithissueconnectedwithnotexistinglibraryAssetIdcolumnindatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_GetLibraryAssetId",
                table: "Holds");

            migrationBuilder.RenameColumn(
                name: "GetLibraryAssetId",
                table: "Holds",
                newName: "LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_GetLibraryAssetId",
                table: "Holds",
                newName: "IX_Holds_LibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetId",
                table: "Holds",
                newName: "GetLibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Holds",
                newName: "IX_Holds_GetLibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_GetLibraryAssetId",
                table: "Holds",
                column: "GetLibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
