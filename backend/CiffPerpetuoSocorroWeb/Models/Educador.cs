using System.ComponentModel.DataAnnotations;

namespace CiffPerpetuoSocorroWeb.Models
{
    public class Educador
    {
        [Key] // Indica que este es el identificador único (ID) en la base de datos, con que se relaciona luego con la tabla de actividas y asi
        public int Id { get; set; }

        [Required] // Hace que el campo sea obligatorio, más puntos
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public string Especialidad { get; set; } // Ejemplo: Maestra Jardinera, Trabajador Social, cocinera y asi 

        // Un educador puede estar en muchas actividades, al igual que los nenes
        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
    }
}
