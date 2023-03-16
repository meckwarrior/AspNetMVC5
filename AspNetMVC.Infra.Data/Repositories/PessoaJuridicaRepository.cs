using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AspNetMVC.Infra.Data.Repositories
{
    public class PessoaJuridicaRepository : RepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public new PessoaJuridica GetById(int id)
        {
            return Db.PessoasJuridicas
                    .Where(p => p.PessoaId == id)
                    .Include(p => p.Endereco)
                    .Include(p => p.Telefones)
                    .FirstOrDefault();
        }

        public new void Update(PessoaJuridica obj)
        {
            new PessoaRepository().Update(obj);
        }

        public IList<PessoaJuridica> GetByFilter(PessoaJuridicaFilter juridicaFilter)
        {
            return Db.PessoasJuridicas
                    .Where(p => (string.IsNullOrEmpty(juridicaFilter.CNPJ) || p.CNPJ.Contains(juridicaFilter.CNPJ))
                            && (string.IsNullOrEmpty(juridicaFilter.RazaoSocial) || p.RazaoSocial.Contains(juridicaFilter.RazaoSocial))
                            && (string.IsNullOrEmpty(juridicaFilter.NomeFantasia) || p.NomeFantasia.Contains(juridicaFilter.NomeFantasia))
                           ).ToList();
        }
    }
}
