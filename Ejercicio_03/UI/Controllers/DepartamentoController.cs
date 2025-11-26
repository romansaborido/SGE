using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoUseCases _departamentoUseCases;

        public DepartamentoController(IDepartamentoUseCases departamentoUseCases)
        {
            _departamentoUseCases = departamentoUseCases;
        }

        public ActionResult Index()
        {
            return View(_departamentoUseCases.getDepartamentos());
        }

        public ActionResult Details(int id)
        {
            return View(_departamentoUseCases.getDepartamento(id));
        }

        // GET: DepartamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentoController/Create
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

        public ActionResult Edit(int id)
        {
            return View(_departamentoUseCases.getDepartamento(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Departamento departamento)
        {
            _departamentoUseCases.updateDepartamento(id, departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(_departamentoUseCases.getDepartamento(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            _departamentoUseCases.deleteDepartamento(id);
            return RedirectToAction("Index");
        }
    }
}
