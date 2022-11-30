using System.ComponentModel.DataAnnotations;

namespace Shoppit
{
    public class Producto
    {
        [Key]
        public int id_producto { get; set; }
        public string? nombre { get; set; }
        public float? precio { get; set; }
        public int? cantidad { get; set; }
    }
}
