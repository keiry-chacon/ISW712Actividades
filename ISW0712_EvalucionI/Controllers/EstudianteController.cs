using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ISW0712_EvalucionI.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly IEstudianteService _estudianteService;

        public EstudianteController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }

        public IActionResult Index()
        {
            var estudiantes = _estudianteService.GetAll();
            return View(estudiantes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _estudianteService.Create(estudiante);
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }
        public IActionResult Edit(int id)
        {
            var estudiante = _estudianteService.FindById(id);
            if (estudiante == null) return NotFound();

            return View(estudiante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Estudiante estudiante)
        {
            if (id != estudiante.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _estudianteService.Edit(estudiante);
                return RedirectToAction(nameof(Index));
            }

            return View(estudiante);
        }
        public IActionResult Detail(int id)
        {
            var estudiante = _estudianteService.FindById(id);
            if (estudiante == null) return NotFound();

            return View(estudiante);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _estudianteService.Delete(id);
            }
            catch (InvalidOperationException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            return RedirectToAction(nameof(Index));
        }
    }

}
