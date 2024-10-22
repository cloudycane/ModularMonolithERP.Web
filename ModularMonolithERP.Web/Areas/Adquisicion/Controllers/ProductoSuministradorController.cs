using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    public class ProductoSuministradorController : Controller
    {
        // GET: ProductoSuministrador
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductoSuministrador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoSuministrador/Create
        public ActionResult Crear()
        {
            return View();
        }

        // POST: ProductoSuministrador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(IFormCollection collection)
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

        // GET: ProductoSuministrador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductoSuministrador/Edit/5
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

        // GET: ProductoSuministrador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoSuministrador/Delete/5
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
