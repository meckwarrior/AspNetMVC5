using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Interfaces.Services;

namespace AspNetMVC.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService)
            : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }
    }
}
