using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class CaTegory
    {
        [Key]
        public int caTegoryID { get; set; }
        public string caTegoryname { get; set; }
        //1-N
        public int abouTmeID { get; set; }
        public AbouTMe AbouTMe { get; set; }
        //admin
        public DateTime? UpdaTeTime { get; set; }
    }
}
