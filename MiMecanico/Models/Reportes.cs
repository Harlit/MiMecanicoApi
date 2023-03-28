using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Reportes
    {
        [Key]
        public int ReporteId { get; set; }
        public string? NombreMecanico { get; set; }
        public string? Estados { get; set; }
    }
}
