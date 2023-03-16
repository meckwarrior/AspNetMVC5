using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Repositories;
using System.Data.Entity;
using System.Linq;

namespace AspNetMVC.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public new void Update(Pessoa obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.Entry(obj.Endereco).State = EntityState.Modified;

            foreach(Telefone telefone in obj.Telefones)
                Db.Entry(telefone).State = EntityState.Modified;

            Db.SaveChanges();
        }
    }
}
