using AutoMapper;
using AspNetMVC.Domain.Entities;
using AspNetMVC.ViewModels;

namespace AspNetMVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaJuridicaViewModel, PessoaJuridica>();
            CreateMap<PessoaFisicaViewModel, PessoaFisica>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<TelefoneViewModel, Telefone>();
        }
    }
}