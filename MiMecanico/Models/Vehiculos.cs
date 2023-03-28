using System.ComponentModel.DataAnnotations;

namespace MiMecanico.Models
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoID { get; set; }
        public string? ProblemaVehiculo { get; set; }
        public string? MarcaVehiculo { set; get; }
        public DateTime AnioVehichulo { set; get; }

    }
}
