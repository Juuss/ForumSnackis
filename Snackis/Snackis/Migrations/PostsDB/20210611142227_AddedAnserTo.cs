using Microsoft.EntityFrameworkCore.Migrations;

namespace Snackis.Migrations.PostsDB
{
    public partial class AddedAnserTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerTo",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerTo",
                table: "Posts");
        }
    }
}
