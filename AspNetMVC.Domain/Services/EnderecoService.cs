using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
            : base (enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

    }
}
