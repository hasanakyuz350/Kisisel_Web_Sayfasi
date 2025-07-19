using Microsoft.AspNetCore.Mvc;
using Staj_Proje.DaTa;
using Staj_Proje.EnTiTy;
using Staj_Proje.MailServices;

namespace Staj_Proje.Controllers
{
    public class ConTacTConTroller : Controller
    {
        readonly Mailsender mailsender;
        private readonly dbconTexT conTexT;
        public ConTacTConTroller(Mailsender mailsender, dbconTexT conTexT)
        {
            this.conTexT = conTexT;
            this.mailsender = mailsender;
        }
        public IActionResult conTacTIndex()
        {
            return View("conTacTIndex");
        }
        [HttpPost]
        public IActionResult conTacTIndex(ConTacT conTacT)
        {
            conTacT.senTTime = DateTime.Now;

            conTexT.conTacTss.Add(conTacT);
            conTexT.SaveChanges();

            mailsender.SendMessageAsync(conTacT);

            return View();
        }
    }
}
