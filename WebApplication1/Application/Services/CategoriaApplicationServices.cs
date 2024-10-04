using Concessionaria.API.Domain.Entities;
using Concessionaria.API.Domain.Interfaces;
using Concessionaria.API.Domain.Interfaces.Dtos;
using Concessionaria.API.Infrastructure.Data.AppData;

namespace Concessionaria.API.Application.Services
{
    public class CategoriaApplicationServices : ICategoriaApplicationService
    {
        private readonly ICategoriaApplicationService _categoriaRepository;

        public CategoriaApplicationServices(ICategoriaApplicationService context)
        {
            _categoriaRepository = context;
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
