using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class NovaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Trening_DbTreningID",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_DbTreningID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DbTreningID",
                table: "Korisnik");

            migrationBuilder.AddColumn<int>(
                name: "DbTreningID",
                table: "Clan",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DbTreningID",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_DbTreningID",
                table: "Korisnik",
                column: "DbTreningID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Trening_DbTreningID",
                table: "Korisnik",
                column: "DbTreningID",
                principalTable: "Trening",
                principalColumn: "DbTreningID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
