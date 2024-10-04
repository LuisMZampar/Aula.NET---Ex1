using Concessionaria.API.Domain.Entities;
using Concessionaria.API.Domain.Interfaces.Dtos;

namespace Concessionaria.API.Domain.Interfaces
{
    public interface ICategoriaApplicationService
    {
        IEnumerable<CategoriaEntity> ObterTodasCategorias();
        CategoriaEntity? ObterCategoriaPorId(int id);
        CategoriaEntity? SalvarDadosCategoria(ICategoriaDto entity);
        CategoriaEntity? EditarDadosCategoria(int id, ICategoriaDto entity);
        CategoriaEntity? DeletarDadosCategoria(int id);
    }
}
