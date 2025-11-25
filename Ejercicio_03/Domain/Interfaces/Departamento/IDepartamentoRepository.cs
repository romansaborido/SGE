using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDepartamentoRepository
    {
        List<Departamento> getDepartamentos();
        Departamento getDepartamento(int id);
        int deleteDepartamento(int id);
        int updateDepartamento(int id, Departamento departamento);
        int addDepartamento(Departamento departamento);
    }
}
