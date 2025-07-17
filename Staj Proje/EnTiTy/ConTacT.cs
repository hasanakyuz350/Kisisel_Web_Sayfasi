using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Staj_Proje.EnTiTy
{
    public class ConTacT
    {
        [Key]
        public int conTacTID { get; set; }
        public string firsTname { get; set; }
        public string lasTname { get; set; }
        public string email { get; set; }
        public string subjecT { get; set; }
        public string message { get; set; }
        public DateTime senTTime { get; set; }
        //admin
        public string? auThorIP { get; set; }
        public DateTime? answercommenTime { get; set; }
    }
}
