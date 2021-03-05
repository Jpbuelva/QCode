using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Entity.Entity
{
    [Table("Imagen")]
    public class ImagenEntity
    {
        [Key]
        public int ImagenId { get; set; }

        public string Foto { get; set; }
    }
}
