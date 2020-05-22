using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Novost",
                columns: table => new
                {
                    NovostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: true),
                    Tekst = table.Column<string>(nullable: true),
                    Slika = table.Column<string>(nullable: true),
                    VrijemeDodavanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novost", x => x.NovostID);
                });

            migrationBuilder.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    OpremaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivOpreme = table.Column<string>(nullable: true),
                    TipZauzetosti = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    NaCekanju = table.Column<bool>(nullable: false),
                    PocetniDatum = table.Column<DateTime>(nullable: false),
                    KrajnjiDatum = table.Column<DateTime>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    KorisnikOpremeKorisnikID = table.Column<int>(nullable: true),
                    Sifra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.OpremaID);
                });

            migrationBuilder.CreateTable(
                name: "Trening",
                columns: table => new
                {
                    TreningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    Kapacitet = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    Tip = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    TrenerKorisnikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trening", x => x.TreningID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Clanarina = table.Column<int>(nullable: true),
                    DatumUclanjivanja = table.Column<DateTime>(nullable: true),
                    BrojPosjeta = table.Column<int>(nullable: true),
                    TrenutnoPrisutan = table.Column<bool>(nullable: true),
                    TreningID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Trening_TreningID",
                        column: x => x.TreningID,
                        principalTable: "Trening",
                        principalColumn: "TreningID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_TreningID",
                table: "Korisnik",
                column: "TreningID");

            migrationBuilder.CreateIndex(
                name: "IX_Oprema_KorisnikOpremeKorisnikID",
                table: "Oprema",
                column: "KorisnikOpremeKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Trening_TrenerKorisnikID",
                table: "Trening",
                column: "TrenerKorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Oprema_Korisnik_KorisnikOpremeKorisnikID",
                table: "Oprema",
                column: "KorisnikOpremeKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trening_Korisnik_TrenerKorisnikID",
                table: "Trening",
                column: "TrenerKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Trening_TreningID",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "Novost");

            migrationBuilder.DropTable(
                name: "Oprema");

            migrationBuilder.DropTable(
                name: "Trening");

            migrationBuilder.DropTable(
                name: "Korisnik");
        }
    }
}
