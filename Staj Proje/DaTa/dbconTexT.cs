using Microsoft.EntityFrameworkCore;
using Staj_Proje.EnTiTy;

namespace Staj_Proje.DaTa
{
    public class dbconTexT : DbContext
    {
        public dbconTexT(DbContextOptions<dbconTexT> baglaTi) : base(baglaTi)
        {

        }
        public DbSet<CommenT> commenT { get; set; }
        public DbSet<ConTacT> conTacT { get; set; }
        public DbSet<Home> mainpage_abouTme { get; set; }
        public DbSet<MyprojecT> myprojecT { get; set; }
    }
}
