using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Web.Models;

namespace Peliculas.Web.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: PeliculasController
        public ActionResult Index()
        {
            List<PeliculasModel> peliculas = new List<PeliculasModel>()
            {
                new PeliculasModel()
                {
                    Id = 1,
                    NombrePelicula = "Transformer",
                    DisponiblesAlquiler = 10,
                    DisponiblesVenta = 5,
                    PrecioAlquiler = 200.00f,
                    PrecioVenta = 1200.00f
                },

                new PeliculasModel()
                {
                    Id = 2,
                    NombrePelicula = "Los Vengadores",
                    DisponiblesAlquiler = 15,
                    DisponiblesVenta = 11,
                    PrecioAlquiler = 230.00f,
                    PrecioVenta = 1300.00f
                }
            };
            return View(peliculas);
        }

        // GET: PeliculasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeliculasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeliculasController/Create
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

        // GET: PeliculasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeliculasController/Edit/5
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

        // GET: PeliculasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeliculasController/Delete/5
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
