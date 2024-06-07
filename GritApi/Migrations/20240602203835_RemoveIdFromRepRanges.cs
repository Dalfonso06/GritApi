using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GritApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdFromRepRanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange");

            migrationBuilder.DropIndex(
                name: "IX_RepRange_ExerciseId",
                table: "RepRange");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RepRange");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange",
                columns: new[] { "ExerciseId", "MinReps", "MaxReps" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RepRange",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepRange",
                table: "RepRange",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepRange_ExerciseId",
                table: "RepRange",
                column: "ExerciseId");
        }
    }
}
