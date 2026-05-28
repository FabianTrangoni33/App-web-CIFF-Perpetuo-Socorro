using Microsoft.EntityFrameworkCore;
using CiffPerpetuoSocorroWeb.Models;

namespace CiffPerpetuoSocorroWeb.Data
{
    // Heredar de DbContext nos ayuda para controlar la Base de Datos, no olviden eso (-V-)
    public class CiffContext : DbContext
    {
        // Este constructor vacío es obligatorio para que .NET le pase la configuración más adelante, asi que no lo borren o pregunten al igual que en todo
        public CiffContext(DbContextOptions<CiffContext> options) : base(options)
        {
        }

        // Los DbSet definen qué tablas se van a crear solas
        // Miren como selectores que le dicen a SQL, como crear la tabla para el molde
        public DbSet<Educador> Educadores { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
    }
}