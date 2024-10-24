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
    public class ProductoSuministradorController : Controller
    {
        private readonly SuministradorGetQuery _suministradorGetQuery;
        private readonly IProductoSuministradorRepositorio _productoSuministradorRepositorio;

        public ProductoSuministradorController(SuministradorGetQuery suministradorGetQuery, IProductoSuministradorRepositorio productoSuministradorRepositorio)
        {
            _suministradorGetQuery = suministradorGetQuery;
            _productoSuministradorRepositorio = productoSuministradorRepositorio;
        }
        // GET: ProductoSuministrador
        public async Task<IActionResult> Index()
        {
            var productos = await _productoSuministradorRepositorio.ObtenerListadoProductoSuministrador();

            var viewModel = new ListadoProductoSuministradorViewModel()
            {
                ProductoSuministradores = productos.ToList()
            };


            return View(viewModel);
        }

        // GET: ProductoSuministrador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoSuministrador/Create
        public async Task<IActionResult> Crear()
        {

            var suministradores = await _suministradorGetQuery.ExecuteAsync();
            var viewModel = new ProductoSuministradorViewModel
            {
                Suministrador = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(suministradores, "Id", "Nombre")

            };


            return View(viewModel);
        }

        // POST: ProductoSuministrador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(ProductoSuministradorViewModel viewModel)
        {
            
            if(ModelState.IsValid)
            {
                var producto = new ProductoSuministradorModel
                {
                    CantidadProducto = viewModel.CantidadProducto,
                    CosteProducto = viewModel.CosteProducto,
                    DescripcionProducto = viewModel.DescripcionProducto,
                    NombreProducto = viewModel.NombreProducto,
                    SuministradorId = viewModel.SuministradorId,
                };

                await _productoSuministradorRepositorio.CrearAsync(producto);
                return RedirectToAction("Index");
            }

            return View(viewModel);
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
