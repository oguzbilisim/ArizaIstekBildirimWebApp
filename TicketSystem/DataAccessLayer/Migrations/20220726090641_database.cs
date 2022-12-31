using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "levels",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_levels", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "statuss",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statuss", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    TitleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles", x => x.TitleID);
                });

            migrationBuilder.CreateTable(
                name: "unitnames",
                columns: table => new
                {
                    UnitNameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitnames", x => x.UnitNameID);
                });

            migrationBuilder.CreateTable(
                name: "employeeinfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    UnitNameID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    titleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeinfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_employeeinfos_levels_LevelID",
                        column: x => x.LevelID,
                        principalTable: "levels",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employeeinfos_statuss_StatusID",
                        column: x => x.StatusID,
                        principalTable: "statuss",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employeeinfos_titles_titleID",
                        column: x => x.titleID,
                        principalTable: "titles",
                        principalColumn: "TitleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employeeinfos_unitnames_UnitNameID",
                        column: x => x.UnitNameID,
                        principalTable: "unitnames",
                        principalColumn: "UnitNameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeinfos_LevelID",
                table: "employeeinfos",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_employeeinfos_StatusID",
                table: "employeeinfos",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_employeeinfos_titleID",
                table: "employeeinfos",
                column: "titleID");

            migrationBuilder.CreateIndex(
                name: "IX_employeeinfos_UnitNameID",
                table: "employeeinfos",
                column: "UnitNameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeinfos");

            migrationBuilder.DropTable(
                name: "levels");

            migrationBuilder.DropTable(
                name: "statuss");

            migrationBuilder.DropTable(
                name: "titles");

            migrationBuilder.DropTable(
                name: "unitnames");
        }
    }
}
