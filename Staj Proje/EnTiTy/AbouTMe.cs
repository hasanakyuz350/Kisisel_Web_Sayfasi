using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class AbouTMe
    {
        [Key]
        public int abouTmeID { get; set; }
        public string abouTme { get; set; }
        public string myBiography { get; set; }
        public List<CaTegory> myTalenT { get; set; } = new();
        public string mypicTureURL { get; set; }
        //admin
        public DateTime? UpdaTeTime { get; set; }
    }
}
