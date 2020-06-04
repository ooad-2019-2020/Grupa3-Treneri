using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class NovaMigracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropIndex(
                name: "IX_Trening_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "TrenerDbKorisnikID",
                table: "Trening");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrenerDbKorisnikID",
                table: "Trening",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trening_TrenerDbKorisnikID",
                table: "Trening",
                column: "TrenerDbKorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening",
                column: "TrenerDbKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "DbKorisnikID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
