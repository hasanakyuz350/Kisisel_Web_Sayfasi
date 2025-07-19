namespace Staj_Proje.Models
{
    public class CommenTmyprojecTModels
    {
        public MyprojecTModels myprojecT { get; set; }
        public CommenTModels CommenTs { get; set; } = new CommenTModels();
        public List<CommenTModels> commenTs { get; set; } = new List<CommenTModels>();
    }
}
