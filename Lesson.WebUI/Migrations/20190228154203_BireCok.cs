using Microsoft.EntityFrameworkCore.Migrations;

namespace Lesson.WebUI.Migrations
{
    public partial class BireCok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weeklyHour",
                table: "Dersler",
                newName: "haftalikSaat");

            migrationBuilder.RenameColumn(
                name: "lessonTeacher",
                table: "Dersler",
                newName: "dersOgretmeni");

            migrationBuilder.RenameColumn(
                name: "lessonName",
                table: "Dersler",
                newName: "dersKodu");

            migrationBuilder.RenameColumn(
                name: "lessonCode",
                table: "Dersler",
                newName: "dersIsmi");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Dersler",
                newName: "DersId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Dersler",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_ApplicationUserId",
                table: "Dersler",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dersler_AspNetUsers_ApplicationUserId",
                table: "Dersler",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dersler_AspNetUsers_ApplicationUserId",
                table: "Dersler");

            migrationBuilder.DropIndex(
                name: "IX_Dersler_ApplicationUserId",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Dersler");

            migrationBuilder.RenameColumn(
                name: "haftalikSaat",
                table: "Dersler",
                newName: "weeklyHour");

            migrationBuilder.RenameColumn(
                name: "dersOgretmeni",
                table: "Dersler",
                newName: "lessonTeacher");

            migrationBuilder.RenameColumn(
                name: "dersKodu",
                table: "Dersler",
                newName: "lessonName");

            migrationBuilder.RenameColumn(
                name: "dersIsmi",
                table: "Dersler",
                newName: "lessonCode");

            migrationBuilder.RenameColumn(
                name: "DersId",
                table: "Dersler",
                newName: "Id");
        }
    }
}
