using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Contabilidad.Controllers
{
    public class CuentasPorCobrarController : Controller
    {
        [Area("Contabilidad")]
        // GET: CuentasPorCobrarController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentasPorCobrarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentasPorCobrarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentasPorCobrarController/Create
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

        // GET: CuentasPorCobrarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentasPorCobrarController/Edit/5
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

        // GET: CuentasPorCobrarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentasPorCobrarController/Delete/5
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
