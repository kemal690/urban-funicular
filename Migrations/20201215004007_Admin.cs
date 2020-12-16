using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_and_web_assignment.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Admin_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_First_Name = table.Column<int>(nullable: false),
                    Admin_Last_Name = table.Column<int>(nullable: false),
                    Admin_Email = table.Column<int>(nullable: false),
                    Admin_Mobile_Number = table.Column<int>(nullable: false),
                    Admin_Address = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Admin_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
