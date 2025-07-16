using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class CommenT
    {
        [Key]
        public int commeTID { get; set; }
        public string auThorname { get; set; }
        public string auThorsurname { get; set; }
        public DateTime wriTeTime { get; set; }
        public MyprojecT projecTID { get; set; }
        //admin
        public string? admnbackcommenT { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleTed { get; set; }

    }
}
