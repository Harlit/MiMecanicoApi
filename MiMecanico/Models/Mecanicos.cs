using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Mecanicos
    {
        [Key]
        public int MecanicoId { get; set; }
        public string? Nombre { get; set; }
        public string? Area { get; set; }
        public string? Disponible { get; set; }
        
    }
}
