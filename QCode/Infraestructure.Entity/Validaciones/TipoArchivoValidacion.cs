using Common.Utils.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entity.Validaciones
{
    public class TipoArchivoValidacion:ValidationAttribute
    {
        private readonly string[] _tiposValidos;

        public TipoArchivoValidacion(string[] tiposValidos)
        {
            _tiposValidos = tiposValidos;
        }
        public TipoArchivoValidacion(GrupoTipoArchivo grupoTipoArchivo)
        {
            if (grupoTipoArchivo == GrupoTipoArchivo.Imagen)
            {
                _tiposValidos = new string[] {"Image/jpeg","image/png", "image/gif" };
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFile = value as IFormFile;
            if (formFile == null)
            {
                return ValidationResult.Success;
            }
            if (_tiposValidos.Contains(formFile.ContentType))
            {
                return new ValidationResult($"El tipo del archivo debe ser uno de los siguientes: {string.Join(", ", _tiposValidos)}");
            }
            return ValidationResult.Success;
        }
    }
}
