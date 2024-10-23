using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithERP.Application.UseCases.GetQueries;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Web.ViewModels;
using ModularMonolithERP.Web.ViewModels.ListadoViewModel;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    [Area("Adquisicion")]
    public class PortalSuministradorController : Controller
    {
        private readonly ISuministradorRepositorio _suministradorRepositorio;
        private readonly ProductoSuministradorGetQuery _productoSuministradorGetQuery;
        public PortalSuministradorController(ISuministradorRepositorio suministradorRepositorio, ProductoSuministradorGetQuery productoSuministradorGetQuery)
        {
            _suministradorRepositorio = suministradorRepositorio;
            _productoSuministradorGetQuery = productoSuministradorGetQuery;
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
        public async Task<IActionResult> Crear()
        {
            var productoSuministrador = await _productoSuministradorGetQuery.ExecuteAsync();

            var viewModel = new SuministradorViewModel
            {
                ProductoSuministradorSelectListItem = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productoSuministrador, "Id", "NombreProducto")
            };
            return View(viewModel);
        }

        // POST: PortalSuministradorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(SuministradorViewModel viewModel)
        {
           
            if (ModelState.IsValid)
            {
                var suministrador = new SuministradorModel()
                {
                    CategoriaProveedor = viewModel.CategoriaProveedor, 
                    Descripcion = viewModel.Descripcion, 
                    Direccion = viewModel.Direccion,
                    CondicionesPagoEnum = viewModel.CondicionesPagoEnum, 
                    Email = viewModel.Email,
                    FormasPago = viewModel.FormasPago, 
                    MetodosTransporte = viewModel.MetodosTransporte,
                    MonedaPreferida = viewModel.MonedaPreferida,
                    Nombre = viewModel.Nombre,
                    PaisOrigen = viewModel.PaisOrigen,
                    ProductoSuministradorId = (int)viewModel.ProductoSuministradorId,
                    TelefonoContacto = viewModel.TelefonoContacto,
                    TipoProveedor = viewModel.TipoProveedor

                };
                await _suministradorRepositorio.CrearAsync(suministrador);
                return RedirectToAction("Index");



            }
            // Recargar el SelectList en caso de que la validación falle
            var productoSuministrador = await _productoSuministradorGetQuery.ExecuteAsync();
            viewModel.ProductoSuministradorSelectListItem = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productoSuministrador, "Id", "Nombre");

            return View(viewModel);

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
