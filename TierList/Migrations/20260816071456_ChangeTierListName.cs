using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierList.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTierListName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_TierLists_TierContainerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_TierLists_TierContainerId",
                table: "Tiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TierLists",
                table: "TierLists");

            migrationBuilder.RenameTable(
                name: "TierLists",
                newName: "TierContainers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TierContainers",
                table: "TierContainers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_TierContainers_TierContainerId",
                table: "Items",
                column: "TierContainerId",
                principalTable: "TierContainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_TierContainers_TierContainerId",
                table: "Tiers",
                column: "TierContainerId",
                principalTable: "TierContainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_TierContainers_TierContainerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_TierContainers_TierContainerId",
                table: "Tiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TierContainers",
                table: "TierContainers");

            migrationBuilder.RenameTable(
                name: "TierContainers",
                newName: "TierLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TierLists",
                table: "TierLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_TierLists_TierContainerId",
                table: "Items",
                column: "TierContainerId",
                principalTable: "TierLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_TierLists_TierContainerId",
                table: "Tiers",
                column: "TierContainerId",
                principalTable: "TierLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
