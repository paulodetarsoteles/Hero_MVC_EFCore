using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class HeroController : Controller
    {
        private readonly IHeroViewModelService _heroViewModelService;

        public HeroController(IHeroViewModelService heroViewModelService)
        {
            _heroViewModelService = heroViewModelService;
        }

        // GET: HeroController
        public ActionResult Index()
        {
            try
            {
                return View(_heroViewModelService.GetAll());
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_heroViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            try
            {
                ViewBag.GetAllPowers = new SelectList(_heroViewModelService.GetAllPowers(), "PowerId", "Name");
                ViewBag.GetAllSecretIdentities = new SelectList(_heroViewModelService.GetAllSecretIdentities(), "SecretIdentityId", "Name");
                return View();
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HeroViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                ViewBag.GetAllPowers = new SelectList(_heroViewModelService.GetAllPowers(), "PowerId", "Name");
                ViewBag.GetAllSecretIdentities = new SelectList(_heroViewModelService.GetAllSecretIdentities(), "SecretIdentityId", "Name");

                viewModel.HeroId = _heroViewModelService.InsertHero(viewModel);

                //if (_remessaRepository.ValidateReferencia(remessa.Referencia))
                //    throw new Exception("Já existe uma referência com este nome.");

                string powersIdList = Request.Form["chkPower"].ToString();

                if (!string.IsNullOrEmpty(powersIdList))
                {
                    int[] splitPowers = powersIdList.Split(',').Select(int.Parse).ToArray();

                    if (splitPowers.Length > 0)
                    {
                        viewModel.Powers = new List<PowerViewModel>();

                        List<PowerViewModel> powers = _heroViewModelService.GetAllPowers();

                        foreach (int powerId in splitPowers)
                        {
                            PowerViewModel power = powers.First(p => p.PowerId == powerId);

                            if (power is not null)
                            {
                                power.HeroId = viewModel.HeroId;
                                viewModel.Powers.Add(powers.First(p => p.PowerId == powerId));
                            }
                        }
                        _heroViewModelService.UpdatePowers(viewModel.Powers);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                ViewBag.GetAllPowers = new SelectList(_heroViewModelService.GetAllPowers(), "PowerId", "Name");
                ViewBag.GetAllSecretIdentities = new SelectList(_heroViewModelService.GetAllSecretIdentities(), "SecretIdentityId", "Name");

                var heroViewModel = _heroViewModelService.GetById(id);
                var powers = _heroViewModelService.GetPowers(id);

                heroViewModel.Powers.AddRange(powers);

                return View(heroViewModel);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HeroViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                ViewBag.GetAllPowers = new SelectList(_heroViewModelService.GetAllPowers(), "PowerId", "Name");
                ViewBag.GetAllSecretIdentities = new SelectList(_heroViewModelService.GetAllSecretIdentities(), "SecretIdentityId", "Name");

                _heroViewModelService.Update(viewModel);

                viewModel.Powers = new();

                string powersIdList = Request.Form["chkPower"].ToString();

                if (!string.IsNullOrEmpty(powersIdList))
                {
                    int[] splitPowers = powersIdList.Split(',').Select(int.Parse).ToArray();

                    if (splitPowers.Length > 0)
                    {
                        List<PowerViewModel> powers = _heroViewModelService.GetAllPowers();

                        foreach (int powerId in splitPowers)
                        {
                            PowerViewModel power = powers.First(p => p.PowerId == powerId);

                            if (power is not null)
                            {
                                power.HeroId = viewModel.HeroId;
                                viewModel.Powers.Add(powers.First(p => p.PowerId == powerId));
                            }
                        }
                    }
                }

                _heroViewModelService.UpdatePowers(viewModel.Powers);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_heroViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection viewModel)
        {
            try
            {
                _heroViewModelService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
