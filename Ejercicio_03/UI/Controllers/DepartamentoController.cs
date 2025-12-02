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
            List<Departamento> departamentos = new List<Departamento>();
            try
            {
                departamentos = _departamentoUseCases.getDepartamentos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(departamentos);
        }

        public ActionResult Details(int id)
        {
            Departamento departamento = new Departamento();
            try
            {
                departamento = _departamentoUseCases.getDepartamento(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(departamento);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Departamento departamento)
        {
            string mensaje;
            int res = 0; 
            try 
            {
                res = _departamentoUseCases.addDepartamento(departamento);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
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
            Departamento departamento = new Departamento();
            try
            {
                departamento = _departamentoUseCases.getDepartamento(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(departamento);
        }

        [HttpPost]
        public ActionResult Edit(int id, Departamento departamento)
        {
            string mensaje;
            int res = 0;
            try
            {
                res = _departamentoUseCases.updateDepartamento(id, departamento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
            Departamento departamento = new Departamento();
            try
            {
                departamento = _departamentoUseCases.getDepartamento(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(departamento);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            string mensaje;
            int res = 0;
            try
            {
                res = _departamentoUseCases.deleteDepartamento(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
