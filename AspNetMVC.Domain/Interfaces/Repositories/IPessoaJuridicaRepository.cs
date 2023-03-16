using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Interfaces.Repositories
{
    public interface  IPessoaJuridicaRepository : IRepositoryBase<PessoaJuridica>
    {
        IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter);
    }
}
