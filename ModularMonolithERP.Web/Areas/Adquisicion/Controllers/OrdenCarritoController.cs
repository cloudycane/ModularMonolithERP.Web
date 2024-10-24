using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Infrastructure.DataAccess;
using ModularMonolithERP.Web.ViewModels.ListadoViewModel;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    [Area("Adquisicion")]
    public class OrdenCarritoController : Controller
    {
        private readonly IProductoSuministradorRepositorio _productoSuministradorRepositorio;
        private readonly ApplicationDbContext _context;
        private readonly IOrdenCarritoRepositorio _ordenCarritoRepositorio;

        public OrdenCarritoController(IProductoSuministradorRepositorio productoSuministradorRepositorio, ApplicationDbContext context, IOrdenCarritoRepositorio ordenCarritoRepositorio)
        {
            _productoSuministradorRepositorio = productoSuministradorRepositorio;
            _context = context;
            _ordenCarritoRepositorio = ordenCarritoRepositorio;

        }
        // GET: OrdenCarritoController
        public async Task<IActionResult> Index()
        {
            var ordenCarrito = await _ordenCarritoRepositorio.ObtenerListadoOrdenCarritoAsync();

            var viewModel = new ListadoOrdenCarritoViewModel()
            {
                OrdenCarritos = ordenCarrito.ToList()
            };
            return View(viewModel);
        }

        // GET: OrdenCarritoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdenCarritoController/Create
        public async Task<IActionResult> AñadirAlCarrito(int productoId)
        {
            // Await the asynchronous call to ensure it's completed before continuing
            var producto = await _productoSuministradorRepositorio.GetProductoAsync(productoId);

            if (producto == null)
            {
                return NotFound();
            }

            var carritoItem = await _context.OrdenesCarritos.SingleOrDefaultAsync(c => c.ProductoSuministradorId == productoId);

            if (carritoItem != null && carritoItem.ProductoSuministrador != null)
            {
                var cantidad = ++carritoItem.Cantidad;
                carritoItem.TotalCoste = carritoItem.Cantidad * carritoItem.ProductoSuministrador.CosteProducto;
                //carritoItem.ProductoSuministrador.CosteProducto = cantidad * carritoItem.ProductoSuministrador.CosteProducto;
            }
            else
            {
                carritoItem = new OrdenCarritoModel
                {
                    ProductoSuministradorId = productoId,
                    Cantidad = 1,
                    FechaCreacion = DateTime.Now,
                    TotalCoste = producto.CosteProducto
                };

                await _context.OrdenesCarritos.AddAsync(carritoItem); 
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        // POST: OrdenCarritoController/Create
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

        // GET: OrdenCarritoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdenCarritoController/Edit/5
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

        // GET: OrdenCarritoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdenCarritoController/Delete/5
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
