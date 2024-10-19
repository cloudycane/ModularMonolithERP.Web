using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Enums;
using ModularMonolithERP.Infrastructure.DataAccess;

namespace ModularMonolithERP.Web.Areas.Contabilidad.Controllers
{
    [Area("Contabilidad")]
    public class CuentaResultadosController : Controller
    {
        // GET: GeneralLedgerController

        private readonly ApplicationDbContext _context;

        public CuentaResultadosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index(TransaccionModel transaccion)
        {
            var totalIngreso = _context.Transacciones
                                        .Where(x => x.TipoTransaccion == TipoTransaccionEnum.Ingreso) // Use the enum value directly
                                        .Sum(x => x.Importe);

            var totalGasto = _context.Transacciones
                                     .Where(x => x.TipoTransaccion == TipoTransaccionEnum.Gasto)
                                     .Sum(x => x.Importe);

            ViewBag.Ingreso = 0 + totalIngreso;
            ViewBag.Gasto = 0 + totalGasto;
            ViewBag.GananciaTotal = totalIngreso - totalGasto;

            return View();
        }

        // GET: GeneralLedgerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneralLedgerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralLedgerController/Create
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

        // GET: GeneralLedgerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneralLedgerController/Edit/5
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

        // GET: GeneralLedgerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneralLedgerController/Delete/5
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
