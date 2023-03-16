using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Domain.Services
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository)
            : base (telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

    }
}
