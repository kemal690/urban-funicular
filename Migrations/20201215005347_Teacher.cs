using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_and_web_assignment.Migrations
{
    public partial class Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Teacher_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_First_Name = table.Column<int>(nullable: false),
                    Teacher_Last_Name = table.Column<int>(nullable: false),
                    Teacher_Email = table.Column<int>(nullable: false),
                    Teacher_Mobile_Number = table.Column<int>(nullable: false),
                    Teacher_Address = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Teacher_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
