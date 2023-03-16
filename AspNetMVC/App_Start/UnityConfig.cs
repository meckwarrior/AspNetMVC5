using AspNetMVC.Application;
using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Interfaces.Repositories;
using AspNetMVC.Domain.Interfaces.Services;
using AspNetMVC.Domain.Services;
using AspNetMVC.Infra.Data.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AspNetMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IPessoaFisicaAppService, PessoaFisicaAppService>();
            container.RegisterType<IPessoaJuridicaAppService, PessoaJuridicaAppService>();
            container.RegisterType<IEnderecoAppService, EnderecoAppService>();
            container.RegisterType<ITelefoneAppService, TelefoneAppService>();

            container.RegisterType<IPessoaFisicaService, PessoaFisicaService>();
            container.RegisterType<IPessoaJuridicaService, PessoaJuridicaService>();
            container.RegisterType<IEnderecoService, EnderecoService>();
            container.RegisterType<ITelefoneService, TelefoneService>();

            container.RegisterType<IPessoaFisicaRepository, PessoaFisicaRepository>();
            container.RegisterType<IPessoaJuridicaRepository, PessoaJuridicaRepository>();
            container.RegisterType<IEnderecoRepository, EnderecoRepository>();
            container.RegisterType<ITelefoneRepository, TelefoneRepository>();


            AutoMapper.AutoMapperConfig.RegisterMappings();
            container.RegisterInstance(AutoMapper.AutoMapperConfig.Mapper);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}