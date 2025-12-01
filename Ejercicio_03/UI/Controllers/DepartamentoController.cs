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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Departamento departamento)
        {
            string mensaje;
            int res = _departamentoUseCases.addDepartamento(departamento);
            if (res > 0)
            {
                mensaje = "El departamento se ha creado correctamente";
            }
            else 
            {
                mensaje = "El departamento no se ha podido crear";
            }
            ViewBag.mensaje = mensaje;
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_departamentoUseCases.getDepartamento(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Departamento departamento)
        {
            string mensaje;
            int res = _departamentoUseCases.updateDepartamento(id, departamento);
            if (res > 0)
            {
                mensaje = "El departamento se ha modificado correctamente";
            }
            else
            {
                mensaje = "El departamento no se ha podido modificar correctamente";
            }
            ViewBag.mensaje = mensaje;
            return View(_departamentoUseCases.getDepartamento(id));
        }

        public ActionResult Delete(int id)
        {
            return View(_departamentoUseCases.getDepartamento(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            string mensaje;
            int res = _departamentoUseCases.deleteDepartamento(id);
            if (res > 0)
            {
                mensaje = "El departamento se ha eliminado correctamente";
            }
            else if (res == -1)
            {
                mensaje = "El departamento no se ha podido eliminar porque tiene personas asociadas";
            }
            else 
            {
                mensaje = "El departamento no se ha podido eliminar";
            }
            ViewBag.mensaje = mensaje;
            return View("Delete", _departamentoUseCases.getDepartamento(id));
        }
    }
}
