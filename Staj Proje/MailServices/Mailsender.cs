using Staj_Proje.DaTa;
using Staj_Proje.EnTiTy;
using System.Net;
using System.Net.Mail;

namespace Staj_Proje.MailServices
{
    public class Mailsender : IMailservices
    {
        private readonly IConfiguration _configuration;
        public Mailsender(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void SendMessageAsync(ConTacT conTacT)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(conTacT.email, conTacT.firsTname + " " + conTacT.lasTname, System.Text.Encoding.UTF8);
            mail.To.Add("hasannn2003@gmail.com");
            mail.Subject = conTacT.subjecT;
            mail.Body = conTacT.message;
            mail.IsBodyHtml = false;
            mail.ReplyToList.Add(new MailAddress(conTacT.email));

            SmtpClient smTp = new SmtpClient(_configuration["Mail:Host"], 587);
            smTp.Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]);
            smTp.EnableSsl = true;

            smTp.Send(mail);
        }
    }
}
