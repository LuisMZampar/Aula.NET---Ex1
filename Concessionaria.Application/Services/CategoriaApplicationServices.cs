using Concessionaria.API.Domain.Entities;
using Concessionaria.API.Domain.Interfaces;
using Concessionaria.API.Domain.Interfaces.Dtos;

namespace Concessionaria.API.Application.Services
{
    public class CategoriaApplicationServices : ICategoriaApplicationService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaApplicationServices(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public CategoriaEntity? DeletarDadosCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? EditarDadosCategoria(int id, ICategoriaDto entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? ObterCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaEntity> ObterTodasCategorias()
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? SalvarDadosCategoria(ICategoriaDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
