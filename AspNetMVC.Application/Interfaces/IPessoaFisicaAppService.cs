using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Application.Interfaces
{
    public interface IPessoaFisicaAppService : IAppServiceBase<PessoaFisica>
    {
        IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter);
    }
}
