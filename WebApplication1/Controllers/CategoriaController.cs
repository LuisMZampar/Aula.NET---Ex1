using Concessionaria.API.Domain.Entities;
using Concessionaria.API.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaApplicationService _categoriaApplicationService;

        public CategoriaController(ICategoriaApplicationService categoriaApplicationService)
        {
            _categoriaApplicationService = categoriaApplicationService;
        }

        [HttpGet]
        [Produces<IEnumerable<CategoriaEntity>>]
        public IActionResult Get()
        {
            var categorias = _categoriaApplicationService.ObterTodasCategorias();

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }
    }
}