using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class PowerController : Controller
    {
        private readonly IPowerViewModelService _powerViewModelService;

        public PowerController(IPowerViewModelService powerViewModelService)
        {
            _powerViewModelService = powerViewModelService;
        }

        // GET: PowerController
        public ActionResult Index()
        {
            try
            {
                return View(_powerViewModelService.GetAll());
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: PowerController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_powerViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: PowerController/Create
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

        // POST: PowerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PowerViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _powerViewModelService.Insert(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: PowerController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return View(_powerViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: PowerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PowerViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _powerViewModelService.Update(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: PowerController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_powerViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: PowerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _powerViewModelService.Delete(id);

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
