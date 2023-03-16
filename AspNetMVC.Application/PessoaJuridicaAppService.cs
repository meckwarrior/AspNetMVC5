using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AspNetMVC.Application
{
    public class PessoaJuridicaAppService : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public PessoaJuridicaAppService(IPessoaJuridicaService pessoaJuridicaService)
            : base(pessoaJuridicaService)
        {
            _pessoaJuridicaService = pessoaJuridicaService;
        }

        public IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter)
        {
            return _pessoaJuridicaService.GetByFilter(juridicaFilter);
        }
    }
}
