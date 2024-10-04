using Concessionaria.API.Domain.Entities;
using Concessionaria.API.Domain.Interfaces;
using Concessionaria.API.Infrastructure.Data.AppData;

namespace Concessionaria.API.Infrastructure.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationContext _context;

        public CategoriaRepository(ApplicationContext context)
        {
            _context = context;
        }
        public CategoriaEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? EditarDados(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity? SalvarDados(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
