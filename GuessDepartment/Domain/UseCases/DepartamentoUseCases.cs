using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases
{
    public class DepartamentoUseCases : IDepartamentoUseCases
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoUseCases(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public Departamento getDepartamentoById(int id)
        {
            return _departamentoRepository.getDepartamentoById(id);
        }

        public List<Departamento> getDepartamentos()
        {
            return _departamentoRepository.getDepartamentos();
        }
    }
}
