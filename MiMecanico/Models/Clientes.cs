using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public DateTime Fecha { get; set; } = DateAndTime.Now;
        public string? ProblemaVehiculo { get; set; }
        public string? MarcaVehiculo { set; get; }
        public DateTime AnioVehichulo { set; get; }
    }
}
