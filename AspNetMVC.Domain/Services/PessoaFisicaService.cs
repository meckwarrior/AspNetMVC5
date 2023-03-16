using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
            : base (pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter)
        {
            return _pessoaFisicaRepository.GetByFilter(fisicaFilter);
        }
    }
}
