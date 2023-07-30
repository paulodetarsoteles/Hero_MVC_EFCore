using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

                _heroViewModelService.Insert(viewModel);

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
                return View(_heroViewModelService.GetById(id));
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

                _heroViewModelService.Update(viewModel);

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
                if (!ModelState.IsValid)
                    return View(viewModel);

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
