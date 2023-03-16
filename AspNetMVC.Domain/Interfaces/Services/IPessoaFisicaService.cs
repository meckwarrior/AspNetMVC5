using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Interfaces.Services
{
    public interface IPessoaFisicaService : IServiceBase<PessoaFisica>
    {
        IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter);
    }
}
