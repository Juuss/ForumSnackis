using Microsoft.EntityFrameworkCore.Migrations;

namespace Snackis.Migrations.PostsDB
{
    public partial class postsdbupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostText",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostText",
                table: "Posts");
        }
    }
}
