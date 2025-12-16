using Domain.DTOs;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.UseCases
{
    public class PlantaUseCases : IPlantaUseCases
    {
		private readonly IPlantaRepository _plantaRepository;
		private readonly ICategoriaUseCases _categoriaUseCases;
        public PlantaUseCases(IPlantaRepository plantaRepository, ICategoriaUseCases categoriaUseCases) {
            _plantaRepository = plantaRepository;
            _categoriaUseCases = categoriaUseCases;
        }

        public PlantasCategoriasDTO getPlantasCategorias(int? idCategoria) {

            PlantasCategoriasDTO dto;

            if (idCategoria == null)
            {
                dto = new PlantasCategoriasDTO(_categoriaUseCases.getCategorias());
            }
            else 
            {
                dto = new PlantasCategoriasDTO(_plantaRepository.getPlantasByCategoria((int)idCategoria), _categoriaUseCases.getCategorias());
            }
            return dto;
        }

        public PlantaDTO getPlantaById(int idPlanta) {

            Planta planta = _plantaRepository.getPlantaById(idPlanta);

            return new PlantaDTO(planta, _categoriaUseCases.getNombreCategoria(planta.idCategoria));
        }

        public int cambiarPrecio(int idPlanta, double nuevoPrecio) {
            return _plantaRepository.cambiarPrecio(idPlanta, nuevoPrecio);
        }
    }
}
