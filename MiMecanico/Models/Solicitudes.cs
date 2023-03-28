using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Solicitudes
    {
        [Key]
        public int SolicitudId { get; set; }
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }
        public string? NombreMecanico { get; set; }
        public string? Area { get; set; }
        public string? NombreCliente { get; set; }
        public DateTime? Fecha { get; set; }
        public string? ProblemaVehiculo { get; set; }
        public string? MarcaVehiculos { get; set; }
        public DateTime? anioVehiculos { get; set; }
        public string? Direccion { get; set; }

    }
}

