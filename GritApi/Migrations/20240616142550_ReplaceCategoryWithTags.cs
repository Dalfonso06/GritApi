using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GritApi.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceCategoryWithTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Category_CategoryId",
                table: "Workout");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Workout_CategoryId",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Workout");

            migrationBuilder.CreateTable(
                name: "HashTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HashTagsWorkout",
                columns: table => new
                {
                    HashTagsId = table.Column<int>(type: "integer", nullable: false),
                    WorkoutsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashTagsWorkout", x => new { x.HashTagsId, x.WorkoutsId });
                    table.ForeignKey(
                        name: "FK_HashTagsWorkout_HashTags_HashTagsId",
                        column: x => x.HashTagsId,
                        principalTable: "HashTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HashTagsWorkout_Workout_WorkoutsId",
                        column: x => x.WorkoutsId,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HashTagsWorkout_WorkoutsId",
                table: "HashTagsWorkout",
                column: "WorkoutsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HashTagsWorkout");

            migrationBuilder.DropTable(
                name: "HashTags");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Workout",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_CategoryId",
                table: "Workout",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Category_CategoryId",
                table: "Workout",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
