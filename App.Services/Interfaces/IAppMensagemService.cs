using App.Models;

namespace App.Services.Interfaces
{
    public interface IAppMensagemService
    {
        void SendMensagem(AppMensagem mensagem);
    }
}
