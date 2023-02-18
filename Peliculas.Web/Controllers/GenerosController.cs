using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Web.Models;

namespace Peliculas.Web.Controllers
{
    public class GenerosController : Controller
    {
        // GET: PeliculasController
        public ActionResult Index()
        {
            List<GenerosModel> generos = new List<GenerosModel>()
            {
                new GenerosModel()
                {
                    Id = 1,
                    Generos = "Accion"
                },

                new GenerosModel()
                {
                    Id = 2,
                    Generos = "Aventura"
                },

                new GenerosModel()
                {
                    Id = 3,
                    Generos = "Romance"
                },

                new GenerosModel()
                {
                    Id = 4,
                    Generos = "Suspenso"
                }
            };
            return View(generos);
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
