using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Web.ViewModels;
using ModularMonolithERP.Web.ViewModels.ListadoViewModel;

namespace ModularMonolithERP.Web.Areas.Contabilidad.Controllers
{
    [Area("Contabilidad")]

    public class TransaccionController : Controller
    {
        private readonly ITransaccionRepositorio _transaccionRepositorio;
        // GET: TransaccionController
       public TransaccionController(ITransaccionRepositorio transaccionRepositorio)
        {
            _transaccionRepositorio = transaccionRepositorio;
        }
        
        public async Task<IActionResult> Index()
        {
           var transacciones = await _transaccionRepositorio.ObtenerListadoTransaccionAsync();

            var viewModel = new ListadoTransaccionViewModel
            {
                Transacciones = transacciones.ToList(),
            };
           return View(viewModel);
        }

        // GET: TransaccionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransaccionController/Create
        // Utilizamos MVVMC por lo tanto hacemos una conversion de viewModel a Model
        public IActionResult Crear() // En GET, no pasamos ningún parametro
        {
            // Aquí sólo pasamos los select list item o dropdown lists (SI NO UTILIZAMOS UN ENUM)
            // Es decir, los contenidos de los dropdown list se obtiene a partir de una base de datos...
            return View();
        }

        // POST: TransaccionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(TransaccionViewModel transaccionViewModel)
        {
        // Si es válido
           if (ModelState.IsValid)
            {
                var transaccion = new TransaccionModel
                {
                    TipoTransaccion = transaccionViewModel.TipoTransaccion,
                    Concepto = transaccionViewModel.Concepto,
                    Importe = transaccionViewModel.Importe,
                    FechaTransaccion = transaccionViewModel.FechaTransaccion, 
                    TipoIngreso = transaccionViewModel.TipoIngreso, 
                    TipoGasto = transaccionViewModel.TipoGasto
                    
                
                };

                await _transaccionRepositorio.CreateAsync(transaccion);
                return RedirectToAction("Index");
            }
        // En contrario
           return View(transaccionViewModel);
        }

        // GET: TransaccionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransaccionController/Edit/5
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

        // GET: TransaccionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransaccionController/Delete/5
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
