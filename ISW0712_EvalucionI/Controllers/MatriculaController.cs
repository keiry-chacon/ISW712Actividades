using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ISW0712_EvalucionI.Controllers
{
    public class MatriculaController : Controller
    {
        private readonly IMatriculaService _matriculaService;
        private readonly IEstudianteService _estudianteService;

        public MatriculaController(IMatriculaService matriculaService, IEstudianteService estudianteService)
        {
            _matriculaService  = matriculaService;
            _estudianteService = estudianteService;
        }

        public IActionResult Index()
        {
            var matriculas = _matriculaService.GetAll();
            return View(matriculas);
        }

        public IActionResult Create()
        {
            var estudiantesNoMatriculados = _estudianteService.GetAll()
        .Where(e => e.Estado == Estado.NoMatriculado)
        .ToList();

            ViewBag.Estudiantes = estudiantesNoMatriculados;

            return View();
        }


        [HttpPost]
        public IActionResult Create(Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                matricula.Fecha = DateTime.UtcNow;

                _matriculaService.Create(matricula);
                return RedirectToAction(nameof(Index));

            }

            var estudiantes = _estudianteService.GetAll();
            ViewBag.Estudientes = estudiantes;
            return View(matricula);
        }


        public IActionResult Edit(int id)
        {
            var matricula = _matriculaService.FindById(id);
            if (matricula == null) return NotFound();

            var estudiantes = _estudianteService.GetAll();
            ViewBag.Estudientes = estudiantes;
            return View(matricula);
        }

        [HttpPost]
        public IActionResult Edit(int id, Matricula matricula)
        {
            if (id != matricula.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _matriculaService.Edit(matricula);
                return RedirectToAction(nameof(Index));
            }

            return View(matricula);
        }

        public IActionResult Detail(int id)
        {
            var matricula = _matriculaService.FindById(id);
            if (matricula == null) return NotFound();

            return View(matricula);
        }

        public IActionResult Delete(int id)
        {
            var matricula = _matriculaService.FindById(id);

            if (matricula == null)
            {
                return NotFound();
            }
            _estudianteService.ChangeStatus(matricula.EstudianteId,Estado.NoMatriculado);
            _matriculaService.Delete(id);  
            return RedirectToAction(nameof(Index));  
        }
    }

}
