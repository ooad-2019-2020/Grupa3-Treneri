using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class TeretanaContext:DbContext
    {
        public TeretanaContext(DbContextOptions<TeretanaContext> options) : base(options)
        {
        }
        public TeretanaContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:ooad.database.windows.net,1433;Initial Catalog=teretana;Persist Security Info=False;User ID=adminaga;Password=Sunlight1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<DbKorisnik> Korisnik { get; set; }
        public DbSet<DbAdmin> Admin { get; set; }
        public DbSet<DbClan> Clan { get; set; }
        public DbSet<DbRecepcioner> Recepcioner { get; set; }
        public DbSet<DbTrener> Trener { get; set; }
        public DbSet<DbTrening> Trening { get; set; }
        public DbSet<DbOprema> Oprema { get; set; }
        public DbSet<DbNovost> Novost { get; set; }
        public DbSet<DbOcjena> Ocjena { get; set; }
        public DbSet<DbClanTrening> ClanTrening { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbKorisnik>().ToTable("Korisnik");
            modelBuilder.Entity<DbAdmin>().ToTable("Admin");
            modelBuilder.Entity<DbClan>().ToTable("Clan");
            modelBuilder.Entity<DbRecepcioner>().ToTable("Recepcioner");
            modelBuilder.Entity<DbTrener>().ToTable("Trener");
            modelBuilder.Entity<DbTrening>().ToTable("Trening");
            modelBuilder.Entity<DbOprema>().ToTable("Oprema");
            modelBuilder.Entity<DbNovost>().ToTable("Novost");
            modelBuilder.Entity<DbOcjena>().ToTable("Ocjena");
            modelBuilder.Entity<DbClan>()
                .HasKey(x => x.DbClanID);

            modelBuilder.Entity<DbTrening>()
                .HasKey(x => x.DbTreningID);

            modelBuilder.Entity<DbClanTrening>()
                .HasKey(x => new { x.DbClanID, x.DbTreningID });
            modelBuilder.Entity<DbClanTrening>()
                .HasOne(x => x.DbClan)
                .WithMany(m => m.Treninzi)
                .HasForeignKey(x => x.DbClanID);
            modelBuilder.Entity<DbClanTrening>()
                .HasOne(x => x.DbTrening)
                .WithMany(e => e.PrijavljeniClanovi)
                .HasForeignKey(x => x.DbTreningID);


            //modelBuilder.Entity<Trener>()
            //.HasRequired<Trening>(s => s.Trener)
            //.WithOne(g => g.Trener)
            //.HasForeignKey<int>(s => s.TrenerID);
        }
    }
}
