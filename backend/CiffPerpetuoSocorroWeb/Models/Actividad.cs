using System.ComponentModel.DataAnnotations;

namespace CiffPerpetuoSocorroWeb.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NombreActividad { get; set; } // En si hay muchas actividades y todos los chicos estan en ellas, pero para cumplir con lo que dice el profe diganos que se van a separar como si eligen su actividad

        public string Descripcion { get; set; }

        public DateTime FechaHora { get; set; } // Cuándo se realiza la actividad, lo cual hay que mejorar mucho en un futuro cuado escale con esto,

        // Aqui se une donde se asignaa al educador con la actividad 
        public int EducadorId { get; set; }
        public Educador Educador { get; set; } // Permite acceder a toda la info del Educador asignado, y es bantante bueno ver los datos de los alumnos tambien

        
        // Una lista que contendrá a todos los niños anotados, todos en una lista
        public List<Beneficiario> Beneficiarios { get; set; } = new List<Beneficiario>();
    }
}
