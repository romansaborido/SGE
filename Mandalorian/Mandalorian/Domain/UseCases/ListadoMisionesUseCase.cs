using Domain.Entities;
using Domain.Interfaces;
using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class ListadoMisionesUseCase : IListadoMisionesUseCases
    {
        private readonly IListadoMisionesRepository _listadoMisiones;

        public ListadoMisionesUseCase(IListadoMisionesRepository listadoMisiones)
        {
            _listadoMisiones = listadoMisiones;
        }

        public List<Mision> getMisiones() 
        {
            DateTime horaActual = DateTime.Now;

            if (horaActual.Hour <= 20)
            {
                return _listadoMisiones.getMisiones();
            }

            return new List<Mision>();
        }

        public Mision getMisionById(int id) 
        {
            List<Mision> listadoMisiones = _listadoMisiones.getMisiones();
            foreach (var mision in listadoMisiones) 
            {
                if (mision.id == id) 
                {
                    return mision;
                }
            }
            throw new Exception($"No se encontró ninguna misión con ID {id}");
        }


        public MisionesWithSelectedMision getMisionesWithSelectedMision(int idSeleccionado) 
        {
            List<Mision> listadoMisiones = getMisiones();
            Mision misionSeleccionada = getMisionById(idSeleccionado);

            return new MisionesWithSelectedMision(listadoMisiones, misionSeleccionada);
        }
    }
}   
