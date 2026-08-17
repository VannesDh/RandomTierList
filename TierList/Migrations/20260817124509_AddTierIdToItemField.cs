using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierList.Migrations
{
    /// <inheritdoc />
    public partial class AddTierIdToItemField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TierId",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TierId",
                table: "Items");
        }
    }
}
