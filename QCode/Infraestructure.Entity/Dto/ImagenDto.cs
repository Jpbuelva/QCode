using Common.Utils.Enum;
using Infraestructure.Entity.Validaciones;
using Microsoft.AspNetCore.Http;

namespace Infraestructure.Entity.Dto
{
    public class ImagenDto
    {
        [PesoArchivoValidacion(4) ]
        [TipoArchivoValidacion(grupoTipoArchivo:GrupoTipoArchivo.Imagen)]
        public IFormFile Foto { get; set; }
    }
}
