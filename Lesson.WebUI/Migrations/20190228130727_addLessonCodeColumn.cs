using Microsoft.EntityFrameworkCore.Migrations;

namespace Lesson.WebUI.Migrations
{
    public partial class addLessonCodeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lessonCode",
                table: "Dersler",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lessonCode",
                table: "Dersler");
        }
    }
}
