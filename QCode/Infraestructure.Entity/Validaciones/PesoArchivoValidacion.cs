using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entity.Validaciones
{
    public class PesoArchivoValidacion : ValidationAttribute
    {
        private readonly int _pesoMaximo;

        public PesoArchivoValidacion(int pesoMaximo)
        {
            _pesoMaximo = pesoMaximo;
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

            if (formFile.Length > _pesoMaximo * 1024 * 1024)
            {
                return new ValidationResult($"El peso del archivo no debe ser mayor a {_pesoMaximo} mb");
            }

            return ValidationResult.Success;
        }
    }
}
