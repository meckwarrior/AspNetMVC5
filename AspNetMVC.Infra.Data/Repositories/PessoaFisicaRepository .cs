using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AspNetMVC.Infra.Data.Repositories
{
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        public new PessoaFisica GetById(int id)
        {
            return Db.PessoasFisicas
                    .Where(p => p.PessoaId == id)
                    .Include(p => p.Endereco)
                    .Include(p => p.Telefones)
                    .FirstOrDefault();
        }

        public new void Update(PessoaFisica obj)
        {
            new PessoaRepository().Update(obj);
        }

        public IList<PessoaFisica> GetByFilter(PesssoaFisicaFilter fisicaFilter)
        {
            return Db.PessoasFisicas
                    .Where(p => (string.IsNullOrEmpty(fisicaFilter.CPF) || p.CPF.Contains(fisicaFilter.CPF))
                            && (string.IsNullOrEmpty(fisicaFilter.Nome) || p.Nome.Contains(fisicaFilter.Nome))
                            && (string.IsNullOrEmpty(fisicaFilter.RG) || p.RG.Contains(fisicaFilter.RG))
                           ).ToList();
        }
    }
}
