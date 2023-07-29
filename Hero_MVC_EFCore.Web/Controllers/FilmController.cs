using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
                viewModel.Rate = Convert.ToInt32(viewModel.Rate);
                _service.Insert(viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
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

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FilmViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _service.Update(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
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
            catch
            {
                return View();
            }
        }
    }
}
