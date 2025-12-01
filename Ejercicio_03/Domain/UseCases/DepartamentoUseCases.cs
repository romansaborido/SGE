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
        private readonly IPersonaRepository _personaRepository;

        public DepartamentoUseCases(IDepartamentoRepository departamentoRepository, IPersonaRepository personaRepository) 
        {
            _departamentoRepository = departamentoRepository;
            _personaRepository = personaRepository;
        }

        public int addDepartamento(Departamento departamento)
        {
            return _departamentoRepository.addDepartamento(departamento);
        }

        public int deleteDepartamento(int id)
        {
            int res = 0;
            if (_personaRepository.countPersonasByDep(id) > 0)
            {
                res = -1;
            }
            else 
            {
                res = _departamentoRepository.deleteDepartamento(id);
            }
            return res;
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
