using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Web.ViewModels;
using ModularMonolithERP.Web.ViewModels.ListadoViewModel;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    [Area("Adquisicion")]
    public class PortalSuministradorController : Controller
    {
        private readonly ISuministradorRepositorio _suministradorRepositorio;

        public PortalSuministradorController(ISuministradorRepositorio suministradorRepositorio)
        {
            _suministradorRepositorio = suministradorRepositorio;
        }


        // GET: PortalSuministradorController
        public async Task<IActionResult> Index()
        {
            var suministradores = await _suministradorRepositorio.ObtenerListadoSuministradorAsync();

            var viewModel = new ListadoSuministradorViewModel()
            {
                Suministradores = suministradores.ToList()

            };
            return View(viewModel);
        }

        // GET: PortalSuministradorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PortalSuministradorController/Create
        public ActionResult Crear()
        {
            return View();
        }

        // POST: PortalSuministradorController/Create
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
