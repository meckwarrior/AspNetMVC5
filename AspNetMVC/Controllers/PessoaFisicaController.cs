using AutoMapper;
using AspNetMVC.Application.Interfaces;
using AspNetMVC.Domain.Entities;
using AspNetMVC.Domain.Filters;
using AspNetMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private readonly IPessoaFisicaAppService _fisicaAppService;
        private readonly IMapper _mapper;

        public PessoaFisicaController(IPessoaFisicaAppService fisicaAppService, IMapper mapper)
        {
            _fisicaAppService = fisicaAppService;
            _mapper = mapper;
        }

        // GET: PessoFisica
        public ActionResult Index(PesssoaFisicaFilter fisicaFilter)
        {
            var pessoaFisicaViewModel = _mapper.Map<IList<PessoaFisica>,
                                        IList<PessoaFisicaViewModel>>(
                                        _fisicaAppService.GetByFilter(fisicaFilter));

            return View(pessoaFisicaViewModel);
        }

        // GET: PessoFisica/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var pessoaFisica = _fisicaAppService.GetById(id);
                var pessoaFisicaViewModel = _mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaFisica);

                return View(pessoaFisicaViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: PessoFisica/Create
        public ActionResult Create()
        {
            return View(new PessoaFisicaViewModel());
        }

        // POST: PessoFisica/Create
        [HttpPost]
        public ActionResult Create(PessoaFisicaViewModel pessoaFisicaViewModel, EnderecoViewModel endereco)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pessoaFisica = _mapper.Map<PessoaFisicaViewModel, PessoaFisica>(pessoaFisicaViewModel);
                    _fisicaAppService.Add(pessoaFisica);

                    return RedirectToAction("Index");
                }

                
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message.Normalize();
            }

            return View(pessoaFisicaViewModel);
        }

        // GET: PessoFisica/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoaFisicaViewModel = new PessoaFisicaViewModel();
            try
            {
                var pessoaFisica = _fisicaAppService.GetById(id);
                pessoaFisicaViewModel = _mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaFisica);

            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
                
            return View(pessoaFisicaViewModel);
        }

        // POST: PessoFisica/Edit/5
        [HttpPost]
        public ActionResult Edit(PessoaFisicaViewModel pessoaFisicaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pessoaFisica = _mapper.Map<PessoaFisicaViewModel, PessoaFisica>(pessoaFisicaViewModel);
                    _fisicaAppService.Update(pessoaFisica);

                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }

            return View(pessoaFisicaViewModel);
        }

        // GET: PessoFisica/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoaFisicaViewModel = new PessoaFisicaViewModel();
            try
            {
                var pessoaFisica = _fisicaAppService.GetById(id);
                pessoaFisicaViewModel  = _mapper.Map<PessoaFisica, PessoaFisicaViewModel>(pessoaFisica);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }

            return View(pessoaFisicaViewModel);
        }

        // POST: PessoFisica/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var pessoaFisica = _fisicaAppService.GetById(id);
                _fisicaAppService.Remove(pessoaFisica);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
