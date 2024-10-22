using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Contabilidad.Controllers
{
    public class ContabilidadGeneralController : Controller
    {
        // GET: ContabilidadGeneralController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContabilidadGeneralController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContabilidadGeneralController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContabilidadGeneralController/Create
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

        // GET: ContabilidadGeneralController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContabilidadGeneralController/Edit/5
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

        // GET: ContabilidadGeneralController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContabilidadGeneralController/Delete/5
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
