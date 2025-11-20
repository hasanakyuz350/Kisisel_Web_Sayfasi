using Microsoft.EntityFrameworkCore;
using Staj_Proje.EnTiTy;

namespace Staj_Proje.DaTa
{
    public class dbconTexT : DbContext
    {
        public dbconTexT(DbContextOptions<dbconTexT> baglaTi) : base(baglaTi)
        {

        }
        public DbSet<AbouTMe> abouTMes { get; set; }
        public DbSet<CaTegory> caTegories { get; set; }
        public DbSet<CommenT> commenTs { get; set; }
        public DbSet<ConTacT> conTacTss { get; set; }
        public DbSet<Home> homes { get; set; }
        public DbSet<MyprojecT> myprojecTs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaTegory>()
                .HasOne(m => m.AbouTMe)
                .WithMany(m => m.myTalenT)
                .HasForeignKey(m => m.abouTmeID);

            modelBuilder.Entity<CommenT>()
              .HasOne(m => m.MyprojecT)
              .WithMany(m => m.commenT)
              .HasForeignKey(c => c.projecTID);

            modelBuilder.Entity<MyprojecT>()
                .HasOne(m => m.Home)
                .WithMany(m => m.mylasTprojecT)
                .HasForeignKey(m => m.homeID);
        }
    }
}
