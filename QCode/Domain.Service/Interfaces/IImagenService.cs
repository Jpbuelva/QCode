using Infraestructure.Entity.Dto;
using System.Threading.Tasks;

namespace Domain.Service.Interfaces
{
    public interface IImagenService
    {
        Task<ImagenDto> Getd(int Id);
        Task<ImagenDto> Post(ImagenDto imagenDto);
    }
}