namespace Staj_Proje.Models
{
    public class HomeModels
    {
        public string TiTle { get; set; }
        public string subTiTle { get; set; }
        public string? ImageURL { get; set; }
        public string shortabouTme { get; set; }
        public List<int> TopprojecT { get; set; }
        public List<MyprojecTModels> mylasTprojecT { get; set; }
    }
}
