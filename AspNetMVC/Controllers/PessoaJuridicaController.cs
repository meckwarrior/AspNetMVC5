using AutoMapper;
using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        private readonly IPessoaJuridicaAppService _juridicaAppService;
        private readonly IMapper _mapper;

        public PessoaJuridicaController(
            IPessoaJuridicaAppService juridicaAppService,
            IMapper mapper)
        {
            _juridicaAppService = juridicaAppService;
            _mapper = mapper;
        }

        // GET: PessoJuridica
        public ActionResult Index(PessoaJuridicaFilter juridicaFilter)
        {
            var pessoaJuridicaViewModel = _mapper.Map<IList<PessoaJuridica>,
                                        IList<PessoaJuridicaViewModel>>(
                                        _juridicaAppService.GetByFilter(juridicaFilter));

            return View(pessoaJuridicaViewModel);
        }

        // GET: PessoJuridica/Details/5
        public ActionResult Details(int id)
        {
            var pessoJuridica = _juridicaAppService.GetById(id);
            var pessoJuridicaViewModel = _mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoJuridica);

            return View(pessoJuridicaViewModel);
        }

        // GET: PessoJuridica/Create
        public ActionResult Create()
        {
            return View(new PessoaJuridicaViewModel());
        }

        // POST: PessoJuridica/Create
        [HttpPost]
        public ActionResult Create(PessoaJuridicaViewModel pessoaJuridicaViewModel)
        {
            if (ModelState.IsValid)
            {
                //pessoaJuridicaViewModel.Endereco = null;
                var pessoaJuridica = _mapper.Map<PessoaJuridicaViewModel, PessoaJuridica>(pessoaJuridicaViewModel);
                _juridicaAppService.Add(pessoaJuridica);

                return RedirectToAction("Index");
            }

            return View(pessoaJuridicaViewModel);
        }

        // GET: PessoJuridica/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoJuridica = _juridicaAppService.GetById(id);
            var pessoJuridicaViewModel = _mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoJuridica);
            return View(pessoJuridicaViewModel);
        }

        // POST: PessoJuridica/Edit/5
        [HttpPost]
        public ActionResult Edit(PessoaJuridicaViewModel pessoaJuridicaViewModel)
        {
            if (ModelState.IsValid)
            {
                var pessoaJuridica = _mapper.Map<PessoaJuridicaViewModel, PessoaJuridica>(pessoaJuridicaViewModel);
                _juridicaAppService.Update(pessoaJuridica);

                return RedirectToAction("Index");
            }

            return View(pessoaJuridicaViewModel);
        }

        // GET: PessoJuridica/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoJuridica = _juridicaAppService.GetById(id);
            var pessoJuridicaViewModel = _mapper.Map<PessoaJuridica, PessoaJuridicaViewModel>(pessoJuridica);
            return View(pessoJuridicaViewModel);
        }

        // POST: PessoJuridica/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var pessoJuridica = _juridicaAppService.GetById(id);
            _juridicaAppService.Remove(pessoJuridica);

            return RedirectToAction("Index");
        }
    }
}
