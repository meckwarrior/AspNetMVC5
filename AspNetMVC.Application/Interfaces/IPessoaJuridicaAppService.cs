using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using System.Collections.Generic;

namespace AspNetMVC.Application.Interfaces
{
    public interface IPessoaJuridicaAppService : IAppServiceBase<PessoaJuridica>
    {
        IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter);
    }
}
