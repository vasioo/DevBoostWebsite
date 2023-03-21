using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevBoost.Data.Migrations
{
    public partial class newnewnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "ExerciseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "ExerciseTable");
        }
    }
}
