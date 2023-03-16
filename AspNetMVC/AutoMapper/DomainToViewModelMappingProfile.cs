using AutoMapper;
using AspNetMVC.Domain.Entities;
using AspNetMVC.ViewModels;

namespace AspNetMVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<PessoaJuridica, PessoaJuridicaViewModel>();
            CreateMap<PessoaFisica, PessoaFisicaViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
        }
    }
}