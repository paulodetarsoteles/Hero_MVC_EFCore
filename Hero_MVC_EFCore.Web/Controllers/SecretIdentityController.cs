using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class SecretIdentityController : Controller
    {
        // GET: SecretIdentityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SecretIdentityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SecretIdentityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecretIdentityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
            return View();
        }

        // POST: SecretIdentityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
            return View();
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
