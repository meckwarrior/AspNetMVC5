using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
            : base (pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

    }
}
