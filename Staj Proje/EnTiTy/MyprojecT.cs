using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class MyprojecT
    {
        [Key]
        public int projecTID { get; set; }
        public string TiTle { get; set; }
        public string shorTdecripTion { get; set; }
        public string descripTion { get; set; }
        public string projecTImageURl { get; set; }
        //1-N
        public List<CommenT> commenT { get; set; } = new();
        //1-N
        public int homeID { get; set; }
        public Home Home { get; set; }
        //auThor
        public string? giThublink { get; set; }
        public string? demolink { get; set; }
        public string? caTegory { get; set; }
        //admin
        public DateTime? updaTeTime { get; set; }
    }
}
