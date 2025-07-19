using Staj_Proje.EnTiTy;

namespace Staj_Proje.MailServices
{
    public interface IMailservices
    {
        void SendMessageAsync(ConTacT conTacT);
    }
}
