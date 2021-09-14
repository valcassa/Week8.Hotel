using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week6.EF.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battle",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.BattleId);
                });

            migrationBuilder.CreateTable(
                name: "Knights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattleKnight",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false),
                    KnightIdId = table.Column<int>(type: "int", nullable: false),
                    KnightId = table.Column<int>(type: "int", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleKnight", x => new { x.BattleId, x.KnightIdId });
                    table.ForeignKey(
                        name: "FK_BattleKnight_Battle_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battle",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleKnight_Knights_KnightIdId",
                        column: x => x.KnightIdId,
                        principalTable: "Knights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KnightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Knights_KnightId",
                        column: x => x.KnightId,
                        principalTable: "Knights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleKnight_KnightIdId",
                table: "BattleKnight",
                column: "KnightIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_KnightId",
                table: "Weapons",
                column: "KnightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleKnight");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Battle");

            migrationBuilder.DropTable(
                name: "Knights");
        }
    }
}
