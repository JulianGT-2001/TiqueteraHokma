using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class ListaSucursales : Controller
    {
        // GET: ListaUsuarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListaUsuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListaUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListaUsuarios/Create
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

        // GET: ListaUsuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListaUsuarios/Edit/5
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

        // GET: ListaUsuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListaUsuarios/Delete/5
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
