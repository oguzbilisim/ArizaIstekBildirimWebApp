using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class database9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoginID",
                table: "employeeinfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employeeinfos_LoginID",
                table: "employeeinfos",
                column: "LoginID");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeinfos_logins_LoginID",
                table: "employeeinfos",
                column: "LoginID",
                principalTable: "logins",
                principalColumn: "LoginID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeinfos_logins_LoginID",
                table: "employeeinfos");

            migrationBuilder.DropIndex(
                name: "IX_employeeinfos_LoginID",
                table: "employeeinfos");

            migrationBuilder.DropColumn(
                name: "LoginID",
                table: "employeeinfos");
        }
    }
}
