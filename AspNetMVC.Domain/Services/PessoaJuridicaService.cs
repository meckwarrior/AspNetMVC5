using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Services
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>, IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaService(IPessoaJuridicaRepository pessoaJuridicaRepository)
            : base (pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }

        public IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter)
        {
            return _pessoaJuridicaRepository.GetByFilter(juridicaFilter);
        }
    }
}
