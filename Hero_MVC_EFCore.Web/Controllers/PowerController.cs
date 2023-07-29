using Microsoft.AspNetCore.Mvc;

namespace Hero_MVC_EFCore.Web.Controllers
{
    public class PowerController : Controller
    {
        // GET: PowerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PowerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PowerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PowerController/Create
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

        // GET: PowerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PowerController/Edit/5
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

        // GET: PowerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PowerController/Delete/5
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
