using Microsoft.EntityFrameworkCore.Migrations;

namespace Snackis.Migrations.PostsDB
{
    public partial class changedid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Posts",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "ID");
        }
    }
}
