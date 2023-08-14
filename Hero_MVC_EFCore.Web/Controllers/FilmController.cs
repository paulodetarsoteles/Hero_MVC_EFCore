using Hero_MVC_EFCore.Web.Service;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmViewModelService _service;

        public FilmController(IFilmViewModelService service)
        {
            _service = service;
        }

        // GET: FilmController
        public ActionResult Index()
        {
            try
            {
                return View(_service.GetAll());
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_service.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: FilmController/Create
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

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FilmViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _service.Insert(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                ViewBag.GetAllHeroes = new SelectList(_service.GetAllHeroes(), "HeroId", "Name");

                return View(_service.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FilmViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                ViewBag.GetAllHeroes = new SelectList(_service.GetAllHeroes(), "HeroId", "Name");

                string heroIdList = Request.Form["chkPower"].ToString();

                if (!string.IsNullOrEmpty(heroIdList))
                {
                    int[] splitHeroes = heroIdList.Split(',').Select(int.Parse).ToArray();

                    if (splitHeroes.Length > 0)
                    {
                        List<HeroViewModel> heroes = _service.GetAllHeroes();
                        viewModel.Heroes = new();

                        foreach (int heroId in splitHeroes)
                        {
                            HeroViewModel hero = heroes.First(h => h.HeroId == heroId);

                            if (hero is not null)
                                viewModel.Heroes.Add(hero));
                        }
                    }
                }

                _service.Update(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var viewmodel = _service.GetById(id);

                return View(viewmodel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _service.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }
    }
}
