using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Interfaces.Repositories
{
    public interface IPessoaFisicaRepository : IRepositoryBase<PessoaFisica>
    {
        IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter);
    }
}
