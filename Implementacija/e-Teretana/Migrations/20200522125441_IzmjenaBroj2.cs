using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_Teretana.Migrations
{
    public partial class IzmjenaBroj2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    DbAdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prijavljen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.DbAdminID);
                });

            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    DbClanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clanarina = table.Column<int>(nullable: false),
                    DatumUclanjivanja = table.Column<DateTime>(nullable: false),
                    BrojPosjeta = table.Column<int>(nullable: false),
                    TrenutnoPrisutan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.DbClanID);
                });

            migrationBuilder.CreateTable(
                name: "Recepcioner",
                columns: table => new
                {
                    DbRecepcionerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PocetakRadnogVremena = table.Column<DateTime>(nullable: false),
                    KrajRadnogVremena = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcioner", x => x.DbRecepcionerID);
                });

            migrationBuilder.CreateTable(
                name: "Trener",
                columns: table => new
                {
                    DbTrenerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trener", x => x.DbTrenerID);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    DbOcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOcjenjivanja = table.Column<DateTime>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    DbTrenerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.DbOcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjena_Trener_DbTrenerID",
                        column: x => x.DbTrenerID,
                        principalTable: "Trener",
                        principalColumn: "DbTrenerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_DbTrenerID",
                table: "Ocjena",
                column: "DbTrenerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Clan");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Recepcioner");

            migrationBuilder.DropTable(
                name: "Trener");
        }
    }
}
