using Domain.Service.Interfaces;
using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Dto;
using Infraestructure.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class ImagenService : IImagenService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ImagenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ImagenDto> Getd(int Id)
        {
            var result = await _unitOfWork.ImagenRepository.GetById(Id);
            var imagenDto = new ImagenDto()
            {

            };
            return new ImagenDto();
        }

        

        public async Task<ImagenDto> Post(ImagenDto imagenDto)
        {
            var imagen = new ImagenEntity
            {
                Foto = "ssmsmsmsmmss"
            };
            await _unitOfWork.ImagenRepository.Add(imagen);

            var result =   _unitOfWork.SaveChangesAsync();
            return new ImagenDto();

        }
    }
}
