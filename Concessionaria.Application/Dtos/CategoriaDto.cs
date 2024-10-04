using Concessionaria.API.Domain.Interfaces.Dtos;

namespace Concessionaria.API.Application.Dtos
{
    public class CategoriaDto : ICategoriaDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public void Validate()
        {
        }
    }
}
