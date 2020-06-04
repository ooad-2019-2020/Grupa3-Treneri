﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_Teretana.Models;

namespace e_Teretana.Migrations
{
    [DbContext(typeof(TeretanaContext))]
    [Migration("20200604141630_NovaMigracija1")]
    partial class NovaMigracija1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("e_Teretana.Models.DbAdmin", b =>
                {
                    b.Property<int>("DbAdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Prijavljen")
                        .HasColumnType("bit");

                    b.HasKey("DbAdminID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("e_Teretana.Models.DbClan", b =>
                {
                    b.Property<int>("DbClanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojPosjeta")
                        .HasColumnType("int");

                    b.Property<int>("Clanarina")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumUclanjivanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TrenutnoPrisutan")
                        .HasColumnType("bit");

                    b.HasKey("DbClanID");

                    b.ToTable("Clan");
                });

            modelBuilder.Entity("e_Teretana.Models.DbClanTrening", b =>
                {
                    b.Property<int>("DbClanID")
                        .HasColumnType("int");

                    b.Property<int>("DbTreningID")
                        .HasColumnType("int");

                    b.HasKey("DbClanID", "DbTreningID");

                    b.HasIndex("DbTreningID");

                    b.ToTable("DbClanTrening");
                });

            modelBuilder.Entity("e_Teretana.Models.DbKorisnik", b =>
                {
                    b.Property<int>("DbKorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DbKorisnikID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("e_Teretana.Models.DbNovost", b =>
                {
                    b.Property<int>("DbNovostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeDodavanja")
                        .HasColumnType("datetime2");

                    b.HasKey("DbNovostID");

                    b.ToTable("Novost");
                });

            modelBuilder.Entity("e_Teretana.Models.DbOcjena", b =>
                {
                    b.Property<int>("DbOcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOcjenjivanja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DbTrenerID")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.HasKey("DbOcjenaID");

                    b.HasIndex("DbTrenerID");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("e_Teretana.Models.DbOprema", b =>
                {
                    b.Property<int>("DbOpremaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnikOpremeDbKorisnikID")
                        .HasColumnType("int");

                    b.Property<DateTime>("KrajnjiDatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NaCekanju")
                        .HasColumnType("bit");

                    b.Property<string>("NazivOpreme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PocetniDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.Property<int>("TipZauzetosti")
                        .HasColumnType("int");

                    b.HasKey("DbOpremaID");

                    b.HasIndex("KorisnikOpremeDbKorisnikID");

                    b.ToTable("Oprema");
                });

            modelBuilder.Entity("e_Teretana.Models.DbRecepcioner", b =>
                {
                    b.Property<int>("DbRecepcionerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("KrajRadnogVremena")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PocetakRadnogVremena")
                        .HasColumnType("datetime2");

                    b.HasKey("DbRecepcionerID");

                    b.ToTable("Recepcioner");
                });

            modelBuilder.Entity("e_Teretana.Models.DbTrener", b =>
                {
                    b.Property<int>("DbTrenerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DbTrenerID");

                    b.ToTable("Trener");
                });

            modelBuilder.Entity("e_Teretana.Models.DbTrening", b =>
                {
                    b.Property<int>("DbTreningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOdrzavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<int>("TrenerDbKorisnikID")
                        .HasColumnType("int");

                    b.HasKey("DbTreningID");

                    b.HasIndex("TrenerDbKorisnikID");

                    b.ToTable("Trening");
                });

            modelBuilder.Entity("e_Teretana.Models.DbClanTrening", b =>
                {
                    b.HasOne("e_Teretana.Models.DbClan", "DbClan")
                        .WithMany("Treninzi")
                        .HasForeignKey("DbClanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Teretana.Models.DbTrening", "DbTrening")
                        .WithMany("PrijavljeniClanovi")
                        .HasForeignKey("DbTreningID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e_Teretana.Models.DbOcjena", b =>
                {
                    b.HasOne("e_Teretana.Models.DbTrener", null)
                        .WithMany("ocjene")
                        .HasForeignKey("DbTrenerID");
                });

            modelBuilder.Entity("e_Teretana.Models.DbOprema", b =>
                {
                    b.HasOne("e_Teretana.Models.DbKorisnik", "KorisnikOpreme")
                        .WithMany()
                        .HasForeignKey("KorisnikOpremeDbKorisnikID");
                });

            modelBuilder.Entity("e_Teretana.Models.DbTrening", b =>
                {
                    b.HasOne("e_Teretana.Models.DbKorisnik", "Trener")
                        .WithMany()
                        .HasForeignKey("TrenerDbKorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
