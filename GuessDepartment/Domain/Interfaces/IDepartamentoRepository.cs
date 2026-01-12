using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDepartamentoRepository
    {
        List<Departamento> getDepartamentos();
        Departamento getDepartamentoById(int id);
    }
}
