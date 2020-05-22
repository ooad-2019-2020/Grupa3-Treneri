using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class IzmjenaBroj1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Trening_TreningID",
                table: "Korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Oprema_Korisnik_KorisnikOpremeKorisnikID",
                table: "Oprema");

            migrationBuilder.DropForeignKey(
                name: "FK_Trening_Korisnik_TrenerKorisnikID",
                table: "Trening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trening",
                table: "Trening");

            migrationBuilder.DropIndex(
                name: "IX_Trening_TrenerKorisnikID",
                table: "Trening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oprema",
                table: "Oprema");

            migrationBuilder.DropIndex(
                name: "IX_Oprema_KorisnikOpremeKorisnikID",
                table: "Oprema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Novost",
                table: "Novost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_TreningID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TreningID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "TrenerKorisnikID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "OpremaID",
                table: "Oprema");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Oprema");

            migrationBuilder.DropColumn(
                name: "KorisnikOpremeKorisnikID",
                table: "Oprema");

            migrationBuilder.DropColumn(
                name: "NovostID",
                table: "Novost");

            migrationBuilder.DropColumn(
                name: "BrojPosjeta",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Clanarina",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DatumUclanjivanja",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TreningID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TrenutnoPrisutan",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Korisnik");

            migrationBuilder.AddColumn<int>(
                name: "DbTreningID",
                table: "Trening",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TrenerDbKorisnikID",
                table: "Trening",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DbOpremaID",
                table: "Oprema",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikOpremeDbKorisnikID",
                table: "Oprema",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DbNovostID",
                table: "Novost",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DbKorisnikID",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DbTreningID",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trening",
                table: "Trening",
                column: "DbTreningID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oprema",
                table: "Oprema",
                column: "DbOpremaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Novost",
                table: "Novost",
                column: "DbNovostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik",
                column: "DbKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Trening_TrenerDbKorisnikID",
                table: "Trening",
                column: "TrenerDbKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Oprema_KorisnikOpremeDbKorisnikID",
                table: "Oprema",
                column: "KorisnikOpremeDbKorisnikID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Oprema_Korisnik_KorisnikOpremeDbKorisnikID",
                table: "Oprema",
                column: "KorisnikOpremeDbKorisnikID",
                principalTable: "Korisnik",
                principalColumn: "DbKorisnikID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Korisnik_Trening_DbTreningID",
                table: "Korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Oprema_Korisnik_KorisnikOpremeDbKorisnikID",
                table: "Oprema");

            migrationBuilder.DropForeignKey(
                name: "FK_Trening_Korisnik_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trening",
                table: "Trening");

            migrationBuilder.DropIndex(
                name: "IX_Trening_TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oprema",
                table: "Oprema");

            migrationBuilder.DropIndex(
                name: "IX_Oprema_KorisnikOpremeDbKorisnikID",
                table: "Oprema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Novost",
                table: "Novost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_DbTreningID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DbTreningID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "TrenerDbKorisnikID",
                table: "Trening");

            migrationBuilder.DropColumn(
                name: "DbOpremaID",
                table: "Oprema");

            migrationBuilder.DropColumn(
                name: "KorisnikOpremeDbKorisnikID",
                table: "Oprema");

            migrationBuilder.DropColumn(
                name: "DbNovostID",
                table: "Novost");

            migrationBuilder.DropColumn(
                name: "DbKorisnikID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DbTreningID",
                table: "Korisnik");

            migrationBuilder.AddColumn<int>(
                name: "TreningID",
                table: "Trening",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Trening",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrenerKorisnikID",
                table: "Trening",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpremaID",
                table: "Oprema",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Oprema",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikOpremeKorisnikID",
                table: "Oprema",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NovostID",
                table: "Novost",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BrojPosjeta",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Clanarina",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumUclanjivanja",
                table: "Korisnik",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TreningID",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrenutnoPrisutan",
                table: "Korisnik",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Korisnik",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trening",
                table: "Trening",
                column: "TreningID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oprema",
                table: "Oprema",
                column: "OpremaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Novost",
                table: "Novost",
                column: "NovostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Trening_TrenerKorisnikID",
                table: "Trening",
                column: "TrenerKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Oprema_KorisnikOpremeKorisnikID",
                table: "Oprema",
                column: "KorisnikOpremeKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_TreningID",
                table: "Korisnik",
                column: "TreningID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Trening_TreningID",
                table: "Korisnik",
                column: "TreningID",
                principalTable: "Trening",
                principalColumn: "TreningID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
