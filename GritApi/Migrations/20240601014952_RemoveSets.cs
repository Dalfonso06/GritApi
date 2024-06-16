using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GritApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sets",
                table: "Exercise");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "Exercise",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
