using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Interfaces.Services
{
    public interface IPessoaJuridicaService : IServiceBase<PessoaJuridica>
    {
        IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter);
    }
}
