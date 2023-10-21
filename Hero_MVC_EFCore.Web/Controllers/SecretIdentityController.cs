using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class SecretIdentityController : Controller
    {
        private readonly ISecretIdentityViewModelService _identityViewModelService;

        public SecretIdentityController(ISecretIdentityViewModelService secretIdentityViewModelService)
        {
            _identityViewModelService = secretIdentityViewModelService;
        }

        // GET: SecretIdentityController
        public ActionResult Index()
        {
            try
            {
                return View(_identityViewModelService.GetAll());
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: SecretIdentityController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_identityViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: SecretIdentityController/Create
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

        // POST: SecretIdentityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SecretIdentityViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(viewModel);

                _identityViewModelService.Insert(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: SecretIdentityController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return View(_identityViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: SecretIdentityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SecretIdentityViewModel viewModel)
        {
            try
            {
                _identityViewModelService.Update(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(viewModel);
            }
        }

        // GET: SecretIdentityController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_identityViewModelService.GetById(id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: SecretIdentityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                _identityViewModelService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(_identityViewModelService.GetById(id));
            }
        }
    }
}
