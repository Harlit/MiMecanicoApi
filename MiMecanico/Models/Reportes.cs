using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Reportes
    {
        [Key]
        public int ReporteId { get; set; }
        public string? NombreMecanico { get; set; }
        public string? NombreCliente { get; set; }
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }
        public string? Estados { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
