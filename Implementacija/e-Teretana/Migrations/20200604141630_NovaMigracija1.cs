using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class NovaMigracija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clan_Trening_DbTreningID",
                table: "Clan");

            migrationBuilder.DropIndex(
                name: "IX_Clan_DbTreningID",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "DbTreningID",
                table: "Clan");

            migrationBuilder.CreateTable(
                name: "DbClanTrening",
                columns: table => new
                {
                    DbClanID = table.Column<int>(nullable: false),
                    DbTreningID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbClanTrening", x => new { x.DbClanID, x.DbTreningID });
                    table.ForeignKey(
                        name: "FK_DbClanTrening_Clan_DbClanID",
                        column: x => x.DbClanID,
                        principalTable: "Clan",
                        principalColumn: "DbClanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbClanTrening_Trening_DbTreningID",
                        column: x => x.DbTreningID,
                        principalTable: "Trening",
                        principalColumn: "DbTreningID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbClanTrening_DbTreningID",
                table: "DbClanTrening",
                column: "DbTreningID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbClanTrening");

            migrationBuilder.AddColumn<int>(
                name: "DbTreningID",
                table: "Clan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clan_DbTreningID",
                table: "Clan",
                column: "DbTreningID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clan_Trening_DbTreningID",
                table: "Clan",
                column: "DbTreningID",
                principalTable: "Trening",
                principalColumn: "DbTreningID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
