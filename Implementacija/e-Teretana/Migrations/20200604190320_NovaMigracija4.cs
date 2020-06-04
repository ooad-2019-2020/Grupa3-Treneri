using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class NovaMigracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.AlterColumn<int>(
                name: "TrenerDbKorisnikID",
                table: "Trening",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DbTrenerID",
                table: "Trening",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening",
                column: "TrenerDbKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "DbKorisnikID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "DbTrenerID",
                table: "Trening");

            migrationBuilder.AlterColumn<int>(
                name: "TrenerDbKorisnikID",
                table: "Trening",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening",
                column: "TrenerDbKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "DbKorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
