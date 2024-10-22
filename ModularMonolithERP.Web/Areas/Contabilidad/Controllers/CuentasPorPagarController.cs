using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Contabilidad.Controllers
{
    [Area("Contabilidad")]
    public class CuentasPorPagarController : Controller
    {
        // GET: CuentasPorPagarController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentasPorPagarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentasPorPagarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentasPorPagarController/Create
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

        // GET: CuentasPorPagarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentasPorPagarController/Edit/5
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

        // GET: CuentasPorPagarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentasPorPagarController/Delete/5
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
