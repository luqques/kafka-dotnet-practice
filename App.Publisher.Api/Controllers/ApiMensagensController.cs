using App.Models;
using App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Publisher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMensagensController : ControllerBase
    {
        private readonly IAppMensagemService _service;

        public ApiMensagensController(IAppMensagemService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddMensagem(AppMensagem mensagem)
        {
            _service.SendMensagem(mensagem);
        }
    }
}
