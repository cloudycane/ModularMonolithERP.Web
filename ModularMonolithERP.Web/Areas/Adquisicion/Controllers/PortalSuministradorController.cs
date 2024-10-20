using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Web.ViewModels;
using ModularMonolithERP.Core.Enums;

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
        public ActionResult Crear()
        {
            return View();
        }

        // POST: PortalSuministradorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(SuministradorViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var suministrador = new SuministradorModel()
                {
                    CapacidadProduccion = viewModel.CapacidadProduccion, 
                    CategoriaProveedor = viewModel.CategoriaProveedor, 
                    CertificacionesLegales = viewModel.CertificacionesLegales,
                    CIF = viewModel.CIF, 
                    CondicionesPago = viewModel.CondicionesPago,
                    ContratoVigente = viewModel.ContratoVigente,
                    CostosLogisticos = viewModel.CostosLogisticos,
                    Descuentos = viewModel.Descuentos,
                    DeudaActual = viewModel.DeudaActual,
                    DiasEntrega = viewModel.DiasEntrega, 
                    DireccionFiscal = viewModel.DireccionFiscal,
                    DocumentosLegales = viewModel.DocumentosLegales,
                    PoliticasDevolucion = viewModel.PoliticasDevolucion,
                    EmailContacto = viewModel.EmailContacto,
                    FechaRegistro = viewModel.FechaRegistro,
                    FechaUltimaAuditoria = viewModel.FechaUltimaAuditoria,
                    FormasPago = viewModel.FormasPago,
                    FrecuenciaCompra = viewModel.FrecuenciaCompra, 
                    GastosEnvio = viewModel.GastosEnvio,
                    HorarioAtencion = viewModel.HorarioAtencion,
                    MetodosTransporte = viewModel.MetodosTransporte,
                    MonedaPreferida = viewModel.MonedaPreferida,
                    PaisOrigen = viewModel.PaisOrigen, 
                    PersonaContacto = viewModel.PersonaContacto, 
                    PlazosEntrega = viewModel.PlazosEntrega, 
                    PrecioProducto = viewModel.PrecioProducto,
                    RazonSocial = viewModel.RazonSocial, 
                    RequisitosRegulatorios = viewModel.RequisitosRegulatorios,
                    RiesgoProveedor = viewModel.RiesgoProveedor, 
                    SitioWeb = viewModel.SitioWeb, 
                    StockMinimo = viewModel.StockMinimo,
                    TelefonoContacto = viewModel.TelefonoContacto,
                    TipoProveedor = viewModel.TipoProveedor, 
                    UnidadMedida = viewModel.UnidadMedida
                };
                await _suministradorRepositorio.CrearSuministrador(suministrador);
                return RedirectToAction("Index");
            }
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
