using System.ComponentModel.DataAnnotations;

namespace CiffPerpetuoSocorroWeb.Models
{
    public class Beneficiario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string Legajo { get; set; } // El número identificador interno en el CIFF

        // Los niños puede estar en muchas actividadess
        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
    }
}