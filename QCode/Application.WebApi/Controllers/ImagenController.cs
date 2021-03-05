using Domain.Service.Interfaces;
using Infraestructure.Entity.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Application.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenController : ControllerBase
    {
        private readonly IImagenService _service;

        public ImagenController(IImagenService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var imagen = await _service.Getd(id);
            return Ok(imagen);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ImagenDto imagen)
        {
            var result = await _service.Post(imagen);
            return Ok(result);
        }
    }
}
