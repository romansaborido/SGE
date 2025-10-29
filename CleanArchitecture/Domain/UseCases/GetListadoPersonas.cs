using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class GetListadoPersonas : IGetListadoPersonasUseCase
    {
        private readonly IListadoPersonasRepository _listadoPersonasRepository;

        public GetListadoPersonas(IListadoPersonasRepository listadoPersonasRepository)
        {
            _listadoPersonasRepository = listadoPersonasRepository;
        }

        public List<Persona> getListadoPersonas() 
        { 
            return _listadoPersonasRepository.getListadoPersonas();
        }
    }
}
