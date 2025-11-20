using Microsoft.AspNetCore.Mvc;
using Staj_Proje.DaTa;
using Staj_Proje.EnTiTy;
using Staj_Proje.MailServices;
using Staj_Proje.Models;

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
        public IActionResult conTacTIndex(ConTacTModels conTacT)
        {
            if (!ModelState.IsValid)
            {
                return View(conTacT);
            }
            var conTacTmodels = new ConTacT
            {
                firsTname = conTacT.firsTname,
                lasTname = conTacT.lasTname,
                email = conTacT.email,
                subjecT = conTacT.subjecT,
                message = conTacT.message,
                senTTime = DateTime.Now
            };

            conTexT.conTacTss.Add(conTacTmodels);
            conTexT.SaveChanges();

            mailsender.SendMessageAsync(conTacTmodels);

            return View();
        }
    }
}
