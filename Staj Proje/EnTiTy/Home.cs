using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class Home
    {
        [Key]
        public int homeID { get; set; }
        public string TiTle { get; set; }
        public string subTiTle { get; set; }
        public string? ImageURL { get; set; }
        public string shortabouTme { get; set; }
        //1-N
        public List<MyprojecT> mylasTprojecT { get; set; } = new();
        //admin
        public DateTime updaTeTime { get; set; }
    }
}
