using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tiquetera.Models;

namespace Tiquetera.Datos
{
    public class AplicationBaseDatos : IdentityDbContext<AppUsuario>
    {
        public AplicationBaseDatos(DbContextOptions options): base(options)
        {
        }

        public DbSet<AppUsuario> listuser { get; set; }
        //public DbSet<TiquetesViewModel> listtickets { get; set; }

    }    
}
