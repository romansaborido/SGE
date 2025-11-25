using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class DepartamentoUseCases : IDepartamentoUseCases
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoUseCases(IDepartamentoRepository departamentoRepository) 
        {
            _departamentoRepository = departamentoRepository;
        }

        public int addDepartamento(Departamento departamento)
        {
            return _departamentoRepository.addDepartamento(departamento);
        }

        public int deleteDepartamento(int id)
        {
            return _departamentoRepository.deleteDepartamento(id);
        }

        public Departamento getDepartamento(int id)
        {
            return _departamentoRepository.getDepartamento(id);
        }

        public List<Departamento> getDepartamentos()
        {
            return _departamentoRepository.getDepartamentos();
        }

        public int updateDepartamento(int id, Departamento departamento)
        {
            return _departamentoRepository.updateDepartamento(id, departamento);
        }
    }
}
