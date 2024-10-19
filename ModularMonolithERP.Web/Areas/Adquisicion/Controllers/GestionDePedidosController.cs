using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    public class GestionDePedidosController : Controller
    {
        // GET: GestionDePedidosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GestionDePedidosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionDePedidosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionDePedidosController/Create
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

        // GET: GestionDePedidosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionDePedidosController/Edit/5
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

        // GET: GestionDePedidosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GestionDePedidosController/Delete/5
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
