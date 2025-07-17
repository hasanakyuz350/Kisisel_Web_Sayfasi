using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class CommenT
    {
        [Key]
        public int commeTID { get; set; }
        public string auThorname { get; set; }
        public string auThorsurname { get; set; }
        public string auThormail { get; set; }
        public string auThormessage { get; set; }
        public DateTime wriTeTime { get; set; }
        //1-N
        public int projecTID { get; set; }
        public MyprojecT MyprojecT { get; set; }
        //admin
        public string? adminbackcommenT { get; set; }
        public bool mayDeleTed { get; set; }

    }
}
