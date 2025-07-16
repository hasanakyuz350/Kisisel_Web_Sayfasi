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
        public List<CommenT> commenT { get; set; }
        //auThor
        public string? giThublink { get; set; }
        public string? demolink { get; set; }
        public List<string?> caTegory { get; set; }
        //admin
        public DateTime? updaTeTime { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleTed { get; set; }
    }
}
