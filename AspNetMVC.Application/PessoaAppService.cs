using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Application
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }
    }
}
