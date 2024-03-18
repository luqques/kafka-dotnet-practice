using App.Models;

namespace App.Repositories.Interfaces
{
    public interface IAppMensagemRepository
    {
        void SendMensagem(AppMensagem mensagem);
    }
}