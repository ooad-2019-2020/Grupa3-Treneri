using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class NovaMigracija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbClanTrening_Clan_DbClanID",
                table: "DbClanTrening");

            migrationBuilder.DropForeignKey(
                name: "FK_DbClanTrening_Trening_DbTreningID",
                table: "DbClanTrening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbClanTrening",
                table: "DbClanTrening");

            migrationBuilder.RenameTable(
                name: "DbClanTrening",
                newName: "ClanTrening");

            migrationBuilder.RenameIndex(
                name: "IX_DbClanTrening_DbTreningID",
                table: "ClanTrening",
                newName: "IX_ClanTrening_DbTreningID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClanTrening",
                table: "ClanTrening",
                columns: new[] { "DbClanID", "DbTreningID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClanTrening_Clan_DbClanID",
                table: "ClanTrening",
                column: "DbClanID",
                principalTable: "Clan",
                principalColumn: "DbClanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClanTrening_Trening_DbTreningID",
                table: "ClanTrening",
                column: "DbTreningID",
                principalTable: "Trening",
                principalColumn: "DbTreningID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClanTrening_Clan_DbClanID",
                table: "ClanTrening");

            migrationBuilder.DropForeignKey(
                name: "FK_ClanTrening_Trening_DbTreningID",
                table: "ClanTrening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClanTrening",
                table: "ClanTrening");

            migrationBuilder.RenameTable(
                name: "ClanTrening",
                newName: "DbClanTrening");

            migrationBuilder.RenameIndex(
                name: "IX_ClanTrening_DbTreningID",
                table: "DbClanTrening",
                newName: "IX_DbClanTrening_DbTreningID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbClanTrening",
                table: "DbClanTrening",
                columns: new[] { "DbClanID", "DbTreningID" });

            migrationBuilder.AddForeignKey(
                name: "FK_DbClanTrening_Clan_DbClanID",
                table: "DbClanTrening",
                column: "DbClanID",
                principalTable: "Clan",
                principalColumn: "DbClanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbClanTrening_Trening_DbTreningID",
                table: "DbClanTrening",
                column: "DbTreningID",
                principalTable: "Trening",
                principalColumn: "DbTreningID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
