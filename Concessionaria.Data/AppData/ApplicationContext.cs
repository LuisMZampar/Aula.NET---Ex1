using Concessionaria.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Concessionaria.API.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<CategoriaEntity> Categoria { get; set; }

     
    }
}
