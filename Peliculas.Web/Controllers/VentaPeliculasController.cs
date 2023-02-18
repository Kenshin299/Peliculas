using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Web.Models;

namespace Peliculas.Web.Controllers
{
    public class VentaPeliculasController : Controller
    {
        // GET: AlquilerPeliculasController
        public ActionResult Index()
        {
            List<VentaPeliculasModel> ventaPeliculas = new List<VentaPeliculasModel>()
            {
                new VentaPeliculasModel()
                {
                    Id = 1,
                    IdPeliculas = 1,
                    IdUsuario = 1,
                    Precio = 1200.00f,
                    Fecha = DateTime.Now,
                },

                new VentaPeliculasModel()
                {
                    Id = 2,
                    IdPeliculas = 2,
                    IdUsuario = 1,
                    Precio = 1300.00f,
                    Fecha = DateTime.Now,
                }

            };
            return View(ventaPeliculas);
        }

        // GET: AlquilerPeliculasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlquilerPeliculasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlquilerPeliculasController/Create
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

        // GET: AlquilerPeliculasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlquilerPeliculasController/Edit/5
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

        // GET: AlquilerPeliculasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlquilerPeliculasController/Delete/5
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
