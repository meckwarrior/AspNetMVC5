using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AspNetMVC.Application
{
    public class PessoaFisicaAppService : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaFisicaAppService(IPessoaFisicaService pessoaFisicaService)
            : base(pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }

        public IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter)
        {
            return _pessoaFisicaService.GetByFilter(fisicaFilter);
        }
    }
}
