using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class database8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    LoginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.LoginID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdminRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    AdminUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminID);
                });
        }
    }
}
