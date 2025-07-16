using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class Home
    {
        [Key]
        public int mainpage_abouTmeID { get; set; }
        public string TiTle { get; set; }
        public string subTiTle { get; set; }
        public string? ImageURL { get; set; }
        public string shortabouTme { get; set; }
        public List<MyprojecT> mylasTprojecT { get; set; }
        public List<int> TopprojecT { get; set; }
        //admin
        public string? mypicTureURL { get; set; }
        public DateTime updaTeTime { get; set; }
    }
}
