using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithERP.Web.Areas.Adquisicion.Controllers
{
    public class SourcingController : Controller
    {
        // GET: SourcingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SourcingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SourcingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SourcingController/Create
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

        // GET: SourcingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SourcingController/Edit/5
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

        // GET: SourcingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SourcingController/Delete/5
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
