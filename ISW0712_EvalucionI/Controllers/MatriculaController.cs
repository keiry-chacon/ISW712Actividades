﻿using ISW0712_EvalucionI.Data;
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

        // Mostrar todas las matrículas
        public IActionResult Index()
        {
            var matriculas = _matriculaService.GetAll();
            return View(matriculas);
        }

        // Crear una nueva matrícula
        public IActionResult Create()
        {
            var estudiantesNoMatriculados = _estudianteService.GetAll()
        .Where(e => e.Estado == Estado.NoMatriculado)
        .ToList();

            ViewBag.Estudiantes = estudiantesNoMatriculados;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                if (matricula.Fecha.Kind == DateTimeKind.Unspecified)
                {
                    matricula.Fecha = DateTime.SpecifyKind(matricula.Fecha, DateTimeKind.Utc);
                }

                // Buscar el estudiante por su ID
                var estudiante = _estudianteService.FindById(matricula.EstudianteId);

                if (estudiante != null)
                {
                    // Cambiar el estado del estudiante a "Matriculado"
                    estudiante.Estado = Estado.Matriculado;

                    // Guardar los cambios del estudiante
                    _estudianteService.Edit(estudiante);

                    // Asignar el estudiante a la matrícula y crearla
                    matricula.Estudiante = estudiante;
                    _matriculaService.Create(matricula);

                    return RedirectToAction(nameof(Index));
                }

                // Si el estudiante no se encuentra, añadir un error al modelo
                ModelState.AddModelError("", "El estudiante no se encuentra.");
            }

            return View(matricula);
        }


        // Editar una matrícula existente
        public IActionResult Edit(int id)
        {
            var matricula = _matriculaService.FindById(id);
            if (matricula == null) return NotFound();

            var estudiantes = _estudianteService.GetAll();
            ViewBag.Estudientes = estudiantes;
            return View(matricula);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // Ver detalles de una matrícula
        public IActionResult Detail(int id)
        {
            var matricula = _matriculaService.FindById(id);
            if (matricula == null) return NotFound();

            return View(matricula);
        }

        // Eliminar una matrícula
        public IActionResult Delete(int id)
        {
            var matricula = _matriculaService.FindById(id);

            if (matricula == null)
            {
                return NotFound();
            }

            var estudiante = _estudianteService.FindById(matricula.EstudianteId);

            if (estudiante != null)
            {
                estudiante.Estado = Estado.NoMatriculado;
                _estudianteService.Edit(estudiante);
            }

            _matriculaService.Delete(id);  
            return RedirectToAction(nameof(Index));  
        }
    }

}
