using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class CategoriaUseCases : ICategoriaUseCases
    {
        private readonly ICategoriaRepository _categoriaRepostory;
        public CategoriaUseCases(ICategoriaRepository categoriaRepository) {
            _categoriaRepostory = categoriaRepository;
        }

        public List<Categoria> getCategorias() {
            return _categoriaRepostory.getCategorias();
        }

        public string getNombreCategoria(int idCategoria) {
            return _categoriaRepostory.getNombreCategoria(idCategoria);
        }
    }
}
