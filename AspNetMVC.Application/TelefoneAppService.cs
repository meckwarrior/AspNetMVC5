using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Application
{
    public class TelefoneAppService : AppServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneAppService(ITelefoneService telefoneService)
            : base(telefoneService)
        {
            _telefoneService = telefoneService;
        }
    }
}
