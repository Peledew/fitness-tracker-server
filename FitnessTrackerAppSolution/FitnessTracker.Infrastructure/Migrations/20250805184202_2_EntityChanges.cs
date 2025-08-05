using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _2_EntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workouts_workoutTypes_WorkoutTypeId",
                table: "workouts");

            migrationBuilder.AddForeignKey(
                name: "FK_workouts_workoutTypes_WorkoutTypeId",
                table: "workouts",
                column: "WorkoutTypeId",
                principalTable: "workoutTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workouts_workoutTypes_WorkoutTypeId",
                table: "workouts");

            migrationBuilder.AddForeignKey(
                name: "FK_workouts_workoutTypes_WorkoutTypeId",
                table: "workouts",
                column: "WorkoutTypeId",
                principalTable: "workoutTypes",
                principalColumn: "Id");
        }
    }
}
