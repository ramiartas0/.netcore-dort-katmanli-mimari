using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduKey.DataAccess.Migrations
{
    public partial class db_e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Educators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EducatorID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Educators");

            migrationBuilder.DropColumn(
                name: "EducatorID",
                table: "Courses");
        }
    }
}
