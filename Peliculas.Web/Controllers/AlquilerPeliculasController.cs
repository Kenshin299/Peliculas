using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Web.Models;

namespace Peliculas.Web.Controllers
{
    public class AlquilerPeliculasController : Controller
    {
        // GET: AlquilerPeliculasController
        public ActionResult Index()
        {
            List<AlquilerPeliculasModel> alquilerPeliculas = new List<AlquilerPeliculasModel>()
            {
                new AlquilerPeliculasModel()
                {
                    Id = 1,
                    IdPeliculas = 1,
                    IdUsuario = 1,
                    Precio = 200.00f,
                    Fecha = DateTime.Now,
                    Devuelta = true,
                    FechaDevolucion = DateTime.Now.AddDays(7),
                    IdUsuarioDevolucion = 1
                },

                new AlquilerPeliculasModel()
                {
                    Id = 2,
                    IdPeliculas = 2,
                    IdUsuario = 1,
                    Precio = 230.00f,
                    Fecha = DateTime.Now,
                    Devuelta = true,
                    FechaDevolucion = DateTime.Now.AddDays(14),
                    IdUsuarioDevolucion = 1
                }

            };
            return View(alquilerPeliculas);
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
