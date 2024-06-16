using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GritApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyForRepRanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepRange_ExerciseId",
                table: "RepRange",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange");

            migrationBuilder.DropIndex(
                name: "IX_RepRange_ExerciseId",
                table: "RepRange");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange",
                columns: new[] { "ExerciseId", "Id" });
        }
    }
}
