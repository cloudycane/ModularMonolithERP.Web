using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    [Area("Adquisicion")]
    public class PortalSuministradorController : Controller
    {
        // GET: PortalSuministradorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PortalSuministradorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PortalSuministradorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PortalSuministradorController/Create
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

        // GET: PortalSuministradorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PortalSuministradorController/Edit/5
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

        // GET: PortalSuministradorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PortalSuministradorController/Delete/5
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
