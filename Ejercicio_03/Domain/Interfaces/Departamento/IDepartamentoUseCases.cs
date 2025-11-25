using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDepartamentoUseCases
    {
        List<Departamento> getDepartamentos();
        Departamento getDepartamento(int id);
        int deleteDepartamento(int id);
        int updateDepartamento(int id, Departamento departamento);
        int addDepartamento(Departamento departamento);
    }
}