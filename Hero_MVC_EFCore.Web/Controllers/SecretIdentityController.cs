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
                return View();
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
                return View();
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecretIdentityController/Edit/5
        public ActionResult Edit(int id)
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

        // POST: SecretIdentityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SecretIdentityViewModel viewModel)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecretIdentityController/Delete/5
        public ActionResult Delete(int id)
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

        // POST: SecretIdentityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
